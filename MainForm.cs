using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace FileSearch
{
    public partial class MainForm : Form
    {
        const string FormText = "Поисковик3000 -v.1.4";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = FormText;
            lblUserName.Text = Environment.UserName;
        }

        private void btnSelectList_Click(object sender, EventArgs e)
        {
            LoadListPC();

            cboxWhereSearch.Text = (cboxWhereSearch.Items.Count > 0) ?
                    $"В списке {cboxWhereSearch.Items.Count} ПК" : "Список ПК пуст";
        }

        private bool IsReadyListPC()
        {
            bool result;
            string fileName = fdOpenPCList.FileName;
            string txtFile = fileName.Substring(fileName.Length - 3);

            result = (txtFile == "txt");

            return result;
        }

        private void LoadListPC()
        {
            if (fdOpenPCList.ShowDialog() == DialogResult.OK)
            {
                if (IsReadyListPC())
                {
                    //Read the contents of the file into a stream
                    var fileStream = fdOpenPCList.OpenFile();

                    StreamReader sr = new StreamReader(fileStream);
                    string str;

                    cboxWhereSearch.Items.Clear();

                    while ((str = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(str)) cboxWhereSearch.Items.Add(str);
                    }

                    fileStream.Close();
                }
                else MessageBox.Show("Ты выбрал не тот файл...");
            }
        }

        private async void btnGO_Click(object sender, EventArgs e)
        {
            lbSearchResult.Items.Clear();
            
            if (cboxWhereSearch.Items.Count > 0) //Проверяем, что список ПК не пуст
            {
                if (tbWhatSearch.Text.Length > 0) //Проверяем, что указан критерий поиска
                {
                    BeforeSearch(); //Действия до начала поиска

                    foreach (var listPC in cboxWhereSearch.Items) //Перебираем все ПК по списку
                    {
                        if (await IsReadyPC(listPC.ToString())) //Проверяем доступность ПК
                        {
                            foreach (var listDrive in DriveName(listPC.ToString())) //Перебираем диски ПК
                            {
                                if (listDrive == '0') //Если пришел символ 0, то где-то в переборе дисков появилась ошибка
                                {
                                    lbSearchResult.Items.Add($"При переборе дисков на ПК {listPC} произошла какая-то ошибка");
                                    continue;
                                }
                                else if(listDrive == '9') //Если пришел символ 9, то в переборе дисков нет доступа
                                {
                                    lbSearchResult.Items.Add($"К дискам на ПК {listPC} нету доступа");
                                    continue;
                                }
                                else
                                {
                                    string dt1 = DateTime.Now.ToLongTimeString();
                                    lbSearchResult.Items.Add(listPC + $": НАЧАЛО ПОИСКА НА ДИСКЕ {listDrive}:\\ В {dt1}");

                                    await foreach (var item in SearchResults(listPC.ToString() + $@"\{listDrive}$"))
                                    {
                                        lbSearchResult.Items.Add(item);
                                    }

                                    DateTime dt2 = DateTime.Parse(DateTime.Now.ToLongTimeString());
                                    lbSearchResult.Items.Add(listPC + $": ПОИСК НА ДИСКЕ {listDrive}:\\ ЗАВЕРШЕН ЗА {dt2 - DateTime.Parse(dt1)}");
                                    lbSearchResult.Items.Add("-------------------------------------------------------");
                                    CountFoundResult();
                                }
                            }
                        }
                        else
                        {
                            lbSearchResult.Items.Add(listPC + ": НЕ ДОСТУПЕН");
                        }
                    }
                }
                else MessageBox.Show("Что ищем?");
            }
            else MessageBox.Show("Где ищем?");

            AfterSearch(); //Действия после поиска

        }

        private void BeforeSearch()
        {
            lblFileFolderFoundCount.Text = "0";
            lblInFileFoundCount.Text = "0";
            lblSearchFileInProgress.Visible = true;

            //lbSearchResult.Enabled = false;
            lbSearchResult.UseWaitCursor = true;
            lbSearchResult.BackColor = Color.FromArgb(255, 240, 240, 240);

            tbWhatSearch.Enabled = false;

            btnSelectList.Enabled = false;
            btnGO.Enabled = false;
            btnSettings.Enabled = false;
            btnUnload.Enabled = false;

            Text = "Идет поиск...";
        }

        private void AfterSearch()
        {
            lblSearchFileInProgress.Visible = false;
            lblActiveFileSearch.Text = "ПОИСК ЗАВЕРШЕН!";

            //lbSearchResult.Enabled = true;
            lbSearchResult.UseWaitCursor = false;
            lbSearchResult.BackColor = Color.FromArgb(255, 255, 255, 255);


            tbWhatSearch.Enabled = true;

            btnSelectList.Enabled = true;
            btnGO.Enabled = true;
            btnSettings.Enabled = true;
            btnUnload.Enabled = true;

            Text = FormText;
        }

        private void CountFoundResult()
        {
            lblFileFolderFoundCount.Text = "0";
            lblInFileFoundCount.Text = "0";

            //Перебираем весь ListBox
            foreach (var item in lbSearchResult.Items)
            {
                string lbItem = item.ToString();

                //if (lbItem.Contains("НА ДИСКЕ") || lbItem.Contains("----------")) continue;
                /*else*/ if (lbItem.Substring(0, 2) == @"\\")
                    lblFileFolderFoundCount.Text = (Convert.ToInt32(lblFileFolderFoundCount.Text) + 1).ToString();
                else if (lbItem.Contains("НАЙДЕНО СОВПАДЕНИЕ"))
                    lblInFileFoundCount.Text = (Convert.ToInt32(lblInFileFoundCount.Text) + 1).ToString();
            }
        }

        private async IAsyncEnumerable<string> SearchResults(string namePC)
        {
            List<string> result = new List<string>();
            WordWork wordW = new WordWork();

            //Если первые 2 символа не \\, то добавить
            if (namePC.Substring(0, 2) != @"\\") namePC = @"\\" + namePC;

            string[] fileExtension = { ".doc", ".docx", ".rtf" };

            var q = SafeEnumerateFiles(namePC, "*.*", SearchOption.AllDirectories);

            await Task.Run(() =>
            {
                foreach (var filePath in q)
                {
                    //lblActiveFileSearch.Text = filePath;

                    if (filePath.ToLower().IndexOf(tbWhatSearch.Text.ToLower()) > -1)
                    {
                        result.Add(filePath);
                        //lbSearchResult.Items.Add(filePath);
                        //lblFileFolderFoundCount.Text = (Convert.ToInt32(lblFileFolderFoundCount.Text) + 1).ToString();
                    }

                    foreach (var fileExt in fileExtension)
                    {
                        //Если вернется true, то пропустить поиск в файле
                        if (SkipCheckInFile(fileExt)) continue;

                        //Если расширение файла = расширение цикла
                        if (Path.GetExtension(filePath) == fileExt)
                        {
                            //Если вернется true, то добавить путь файла в List
                            if (wordW.CheckInWordFile(filePath ,tbWhatSearch.Text, out string exception))
                                result.Add("НАЙДЕНО СОВПАДЕНИЕ В ФАЙЛЕ: " + filePath);
                            //Если возвращается false, то проверяем на наличие исключения
                            else if (exception != null)
                                result.Add(exception + ": " + filePath);
                        }
                    }
                }
            });

            wordW.WordQuit();

            //return result;
            foreach (string item in result.Reverse<string>())
            {
                yield return item;
            }
        }

        private bool SkipCheckInFile(string fileExtension)
        {
            bool result = false;

            if (fileExtension == ".doc")
                if (Properties.Settings.Default.chkbDoc) 
                    result = true;

            if (fileExtension == ".docx")
                if (Properties.Settings.Default.chkbDocx) 
                    result = true;

            if (fileExtension == ".rtf")
                if (Properties.Settings.Default.chkbRtf) 
                    result = true;

            return result;
        }

        /// <summary>
        /// Возвращает перечисляемую коллекцию имен файлов которые соответствуют шаблону в указанном каталоге, с дополнительным просмотром вложенных каталогов
        /// </summary>
        /// <param name="path">Полный или относительный путь катага в котором выполняется поиск</param>
        /// <param name="searchPattern">Шаблон поиска файлов</param>
        /// <param name="searchOption">Одно из значений перечисления SearchOption указывающее нужно ли выполнять поиск во вложенных каталогах или только в указанном каталоге</param>
        /// <returns>Возвращает перечисляемую коллекцию полных имен файлов</returns>
        private IEnumerable<string> SafeEnumerateFiles(string path, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            var dirs = new Stack<string>();
            dirs.Push(path);

            while (dirs.Count > 0)
            {
                var files = new List<string>();

                string currentDirPath = dirs.Pop();
                if (searchOption == SearchOption.AllDirectories)
                {
                    try
                    {
                        string[] subDirs = Directory.GetDirectories(currentDirPath);
                        foreach (string subDirPath in subDirs)
                        {
                            if (SkipFolder(subDirPath)) continue;

                            dirs.Push(subDirPath);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        if (dirs.Count == 1)
                            files.Add("Нет доступа к " + currentDirPath);
                        continue;
                    }
                    catch (DirectoryNotFoundException)
                    {
                        continue;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "ArgumentException (SafeEnumerateFiles)");
                        break;
                    }
                    catch (IOException)
                    {
                        continue;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception (SafeEnumerateFiles)");
                        break;
                    }
                }

                //string[] files = null;
                try
                {
                    foreach (var item in Directory.GetFileSystemEntries(currentDirPath, $"*{searchPattern}*"))
                    {
                        files.Add(item);
                    }
                    //files = Directory.GetFileSystemEntries(currentDirPath, $"*{searchPattern}*");
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
                catch (DirectoryNotFoundException)
                {
                    continue;
                }
                catch (PathTooLongException)
                {
                    continue;
                }

                foreach (string filePath in files)
                {
                    yield return filePath;
                }
            }
        }

        private bool SkipFolder(string subDirPath)
        {
            bool result = false;

            //Исключает из поиска указанные папки
            if (subDirPath.Substring(subDirPath.Length - 8).ToLower() == "\\Windows".ToLower())
                if (Properties.Settings.Default.chkbWindows) result = true;
            if (subDirPath.Substring(subDirPath.Length - 13).ToLower() == "\\$Recycle.Bin".ToLower())
                if (Properties.Settings.Default.chkbRecycle) result = true;
            if (subDirPath.Substring(subDirPath.Length - 5).ToLower() == "\\Temp".ToLower())
                if (Properties.Settings.Default.chkbTemp) result = true;
            if (subDirPath.Substring(subDirPath.Length - 14).ToLower() == "\\Program Files".ToLower())
                if (Properties.Settings.Default.chkbProgram) result = true;
            if (subDirPath.Substring(subDirPath.Length - 20).ToLower() == "\\Program Files (x86)".ToLower())
                if (Properties.Settings.Default.chkbProgram86) result = true;

            //Исключает из поиска указанные пользователем папки
            string[] excepFolders = Properties.Settings.Default.anyFolders.Split(';');
            foreach (var item in excepFolders)
            {
                string tmpItem = item.Trim();
                if (Path.GetFileName(subDirPath).ToLower() == tmpItem.ToLower())
                    result = true;
            }

            return result;
        }

        private void lbSearchResult_DoubleClick(object sender, EventArgs e)
        {
            if ((lbSearchResult.SelectedItem != null)/* && (lbSearchResult.SelectedIndex != 0) && (lbSearchResult.SelectedIndex != lbSearchResult.Items.Count - 1)*/)
            {
                string selectedItem = lbSearchResult.SelectedItem.ToString();

                if (selectedItem.Substring(0, 2) == @"\\" || selectedItem.Contains("НАЙДЕНО СОВПАДЕНИЕ В ФАЙЛЕ"))
                {
                    int tmpStart = selectedItem.IndexOf("\\\\");
                    string selectedItemPath = selectedItem.Substring(tmpStart, selectedItem.Length - tmpStart);
                    //Проверка на каталог
                    if (Directory.Exists(selectedItemPath))
                    {
                        Process.Start("explorer", Path.GetFullPath(selectedItemPath));
                    }
                    else if (File.Exists(selectedItemPath))
                    {
                        Process.Start("explorer", Path.GetDirectoryName(selectedItemPath));
                    }
                    
                }
            }
        }

        private async Task<bool> IsReadyPC(string namePC)
        {
            Ping ping = new Ping();
            PingReply pingReply;
            bool result;

            try
            {
                pingReply = await ping.SendPingAsync(namePC, 128);

                result = (pingReply.Status.ToString() == "Success");
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        private char[] DriveName(string namePC)
        {
            int tmpArrCount = 0;

            try
            {
                ManagementObjectSearcher searcher13 =
                new ManagementObjectSearcher("\\\\" + namePC + "\\root\\CIMV2",
                    "SELECT * FROM Win32_LogicalDisk");

                ////Считаем количество дисков для объявления массива
                foreach (ManagementObject queryObj in searcher13.Get())
                {
                    if (Convert.ToInt32(queryObj["drivetype"]) == 3) tmpArrCount++;
                }

                char[] result = new char[tmpArrCount];
                int tmp = 0;

                foreach (ManagementObject queryObj in searcher13.Get())
                {
                    if (Convert.ToInt32(queryObj["DriveType"]) == 3) //DriveType == 3 - значит, что это локальный диск
                    {
                        result[tmp++] = Convert.ToChar(queryObj["Name"].ToString().Substring(0, 1));
                        //textBox1.Text += queryObj["Name"].ToString() + "\r\n";
                        //textBox1.Text += "-----------------------------\r\n";
                    }
                }

                return result;
            }
            catch (UnauthorizedAccessException)
            {
                char[] res = { '9' };
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(namePC + "\r\n" + ex.ToString(), "DriveName");
                char[] res = { '0' };
                return res;
            }
        }

        //private void CheckInFile(string pathFile, Object findText)
        //{
        //    if (rbtnSaveResources.Checked)
        //    {
        //        wordApp = new Word.Application();
        //        //wordApp.Visible = false;
        //    }

        //    wordApp.Visible = false;
        //    Object saveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
        //    try
        //    {
        //        var doc = wordApp.Application.Documents.OpenNoRepairDialog(pathFile, ReadOnly: true);
        //        doc.Activate();
        //        foreach (Word.Range range in doc.StoryRanges)
        //        {
        //            Word.Find find = range.Find;
        //            if (find.Execute(ref findText))
        //            {
        //                lbSearchResult.Items.Add("НАЙДЕНО СОВПАДЕНИЕ В ФАЙЛЕ: " + pathFile);
        //                lblInFileFoundCount.Text = (Convert.ToInt32(lblInFileFoundCount.Text) + 1).ToString();
        //                //MessageBox.Show(pathFile);
        //            }
        //        }

        //        if (rbtnSaveResources.Checked)
        //            wordApp.Application.ActiveDocument.Close(saveChanges);
        //    }
        //    catch (Exception ex)
        //    {
        //        if (ex.GetType().ToString() != "System.Runtime.InteropServices.COMException")
        //            lbSearchResult.Items.Add($"{ex.Message}: {pathFile}");
        //    }

        //    if (rbtnSaveResources.Checked) wordApp?.Quit(ref saveChanges);
        //}

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FileSearch_MouseHover(object sender, EventArgs e)
        {
            //if ((sender as GroupBox)?.Name == "gboxOptimization")
            //{
            //    ttFileSearch.SetToolTip(gboxOptimization, "Скорость: Значительно ускоряет поиск, но может потреблять много ОЗУ\r\n" +
            //        "Ресурсы: Потребляет мало ОЗУ, но уходит очень много времени на поиск в файле");
            //}
            //if ((sender as RadioButton)?.Name == "rbtnSpeed")
            //{
            //    ttFileSearch.SetToolTip(rbtnSpeed, "Значительно ускоряет поиск, но может потреблять много ОЗУ");
            //}
            //if ((sender as RadioButton)?.Name == "rbtnSaveResources")
            //{
            //    ttFileSearch.SetToolTip(rbtnSaveResources, "Потребляет мало ОЗУ, но уходит очень много времени на поиск в файле");
            //}
        }

        private void tbWhatSearch_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnGO.PerformClick();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile());

                foreach (var item in lbSearchResult.Items)
                {
                    sw.WriteLine(item);
                }

                sw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbSearchResult.SelectedItem.ToString().Contains("НАЙДЕНО СОВПАДЕНИЕ В ФАЙЛЕ"))
            {
                MessageBox.Show(lbSearchResult.SelectedItem.ToString().IndexOf("\\\\").ToString());
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}