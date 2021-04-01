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
        private Word.Application wordApp;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text += " -v.1.3";
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

        private void btnGO_Click(object sender, EventArgs e)
        {
            lbSearchResult.Items.Clear();
            
            if (cboxWhereSearch.Items.Count > 0) //Проверяем, что список ПК не пуст
            {
                if (tbWhatSearch.Text.Length > 0) //Проверяем, что указан критерий поиска
                {
                    BeforeSearch();

                    foreach (var listPC in cboxWhereSearch.Items) //Перебираем все ПК по списку
                    {
                        if (IsReadyPC(listPC.ToString())) //Проверяем доступность ПК
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
                                    if (rbtnSpeed.Checked)
                                    {
                                        wordApp = new Word.Application();
                                        //wordApp.Visible = false;
                                    }

                                    lbSearchResult.Items.Add(listPC + $": НАЧАЛО ПОИСКА НА ДИСКЕ {listDrive}:\\");
                                    ResultOut(listPC.ToString() + $@"\{listDrive}$");
                                    lbSearchResult.Items.Add(listPC + $": ПОИСК НА ДИСКЕ {listDrive}:\\ ЗАВЕРШЕН");
                                    lbSearchResult.Items.Add("-------------------------------------------------------");

                                    if (rbtnSpeed.Checked)
                                    {
                                        Object saveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
                                        try
                                        {
                                            wordApp.Application.ActiveDocument?.Close(saveChanges);
                                            wordApp.Application.ActiveWindow?.Close(saveChanges);
                                        }
                                        catch (Exception) { }

                                        wordApp?.Quit(ref saveChanges);
                                    }
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

            AfterSearch();
        }

        private void BeforeSearch()
        {
            lblFileFolderFoundCount.Text = "0";
            lblInFileFoundCount.Text = "0";
            lbSearchResult.Enabled = false;
            lblSearchFileInProgress.Visible = true;
            gboxOptimization.Enabled = false;
            btnSelectList.Enabled = false;
            tbWhatSearch.Enabled = false;
            btnGO.Enabled = false;
            btnSettings.Enabled = false;
        }

        private void AfterSearch()
        {
            lblSearchFileInProgress.Visible = false;
            lbSearchResult.Enabled = true;
            gboxOptimization.Enabled = true;
            btnSelectList.Enabled = true;
            tbWhatSearch.Enabled = true;
            btnGO.Enabled = true;
            btnSettings.Enabled = true;
            lblActiveFileSearch.Text = "ПОИСК ЗАВЕРШЕН!";

        }

        private void ResultOut(object PC)
        {
            string namePC = PC.ToString();

            if (namePC.Substring(0, 2) != @"\\") namePC = @"\\" + namePC;

            string[] fileExtension = { ".doc", ".docx", ".rtf" };

            var q = SafeEnumerateFiles(namePC, "*.*", SearchOption.AllDirectories);

            foreach (var filePath in q)
            {
                lblActiveFileSearch.Text = filePath;

                if (filePath.ToLower().IndexOf(tbWhatSearch.Text.ToLower()) > -1)
                {
                    lbSearchResult.Items.Add(filePath);
                    lblFileFolderFoundCount.Text = (Convert.ToInt32(lblFileFolderFoundCount.Text) + 1).ToString();
                }

                foreach (var fileExt in fileExtension)
                {
                    if (SkipCheckInFile(fileExt)) continue;
                    
                    if (Path.GetExtension(filePath) == fileExt)
                    {
                        CheckInFile(filePath, tbWhatSearch.Text);
                    }
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Directory.Exists(tbWhatSearch.Text).ToString());
            //CheckInFile("qwe", "ewq");

            string[] str = Properties.Settings.Default.anyFolders.Split(';');

            var sxcd = Path.GetFileName(@"C:\Windows\System32");

            foreach (var item in Directory.GetDirectories(@"C:\Windows\System32"))
            {

            }
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
                string currentDirPath = dirs.Pop();
                if (searchOption == SearchOption.AllDirectories)
                {
                    try
                    {
                        string[] subDirs = Directory.GetDirectories(currentDirPath);
                        foreach (string subDirPath in subDirs)
                        {
                            ////Исключает из поиска указанные папки
                            //if (subDirPath.Substring(subDirPath.Length - 8).ToLower() == "\\Windows".ToLower())
                            //    if (Properties.Settings.Default.chkbWindows) continue;
                            //if (subDirPath.Substring(subDirPath.Length - 13).ToLower() == "\\$Recycle.Bin".ToLower())
                            //    if (Properties.Settings.Default.chkbRecycle) continue;
                            //if (subDirPath.Substring(subDirPath.Length - 5).ToLower() == "\\Temp".ToLower())
                            //    if (Properties.Settings.Default.chkbTemp) continue;
                            //if (subDirPath.Substring(subDirPath.Length - 14).ToLower() == "\\Program Files".ToLower())
                            //    if (Properties.Settings.Default.chkbProgram) continue;
                            //if (subDirPath.Substring(subDirPath.Length - 20).ToLower() == "\\Program Files (x86)".ToLower())
                            //    if (Properties.Settings.Default.chkbProgram86) continue;

                            ////Исключает из поиска указанные пользователем папки
                            //string[] excepFolders = Properties.Settings.Default.anyFolders.Split(';');
                            //foreach (var item in excepFolders)
                            //{

                            //}

                            if (SkipFolder(subDirPath)) continue;

                            dirs.Push(subDirPath);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        continue;
                    }
                    catch (DirectoryNotFoundException)
                    {
                        continue;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }
                    catch (IOException)
                    {
                        continue;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "SafeEnumerateFiles");
                        break;
                    }
                }

                string[] files = null;
                try
                {
                    files = Directory.GetFileSystemEntries(currentDirPath, $"*{searchPattern}*");
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
            if ((lbSearchResult.SelectedItem != null) && (lbSearchResult.SelectedIndex != 0) && (lbSearchResult.SelectedIndex != lbSearchResult.Items.Count - 1))
            {
                //Проверка на каталог                                           //Если содержит точку, то это файл
                if (Directory.Exists(lbSearchResult.SelectedItem.ToString()))   //lbSearchResult.SelectedItem.ToString().Contains('.'))
                {
                    string tmp;

                    tmp = Path.GetDirectoryName(lbSearchResult.SelectedItem.ToString());

                    Process.Start("explorer", tmp);
                }
                                                                                //Если точки нет, то это каталог
                else
                {
                    Process.Start("explorer", lbSearchResult.SelectedItem.ToString());
                }
            }
        }

        private bool IsReadyPC(string namePC)
        {
            Ping ping = new Ping();
            PingReply pingReply;
            bool result;

            try
            {
                pingReply = ping.Send(namePC, 128);

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

        private void CheckInFile(string pathFile, Object findText)
        {
            if (rbtnSaveResources.Checked)
            {
                wordApp = new Word.Application();
                //wordApp.Visible = false;
            }

            wordApp.Visible = false;
            Object saveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
            try
            {
                var doc = wordApp.Application.Documents.Open(pathFile, ReadOnly: true);
                doc.Activate();
                foreach (Word.Range range in doc.StoryRanges)
                {
                    Word.Find find = range.Find;
                    if (find.Execute(ref findText))
                    {
                        lbSearchResult.Items.Add("НАЙДЕНО СОВПАДЕНИЕ В ФАЙЛЕ: " + pathFile);
                        lblInFileFoundCount.Text = (Convert.ToInt32(lblInFileFoundCount.Text) + 1).ToString();
                        //MessageBox.Show(pathFile);
                    }
                }

                if (rbtnSaveResources.Checked)
                    wordApp.Application.ActiveDocument.Close(saveChanges);
            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() != "System.Runtime.InteropServices.COMException")
                    lbSearchResult.Items.Add($"{ex.Message}: {pathFile}");
            }

            if (rbtnSaveResources.Checked) wordApp?.Quit(ref saveChanges);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Object saveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
            //wordApp?.Application.ActiveDocument?.Close(saveChanges);
            try
            {
                wordApp?.Quit(ref saveChanges);
            }
            catch (Exception) { }
        }

        private void FileSearch_MouseHover(object sender, EventArgs e)
        {
            //if ((sender as GroupBox)?.Name == "gboxExceptionFolder")
            //{
            //    ttFileSearch.SetToolTip(gboxExceptionFolder, "Можно исключать из поиска указанные папки");
            //}
            //if ((sender as CheckBox)?.Name == "chkboxWindowsFolder")
            //{
            //    ttFileSearch.SetToolTip(chkboxWindowsFolder, "Если включено, то из поиска исключается папка Windows");
            //}
            //if ((sender as CheckBox)?.Name == "chkboxRecycleFolder")
            //{
            //    ttFileSearch.SetToolTip(chkboxRecycleFolder, "Если включено, то из поиска исключается папка Корзина ($Recycle.bin)");
            //}
            //if ((sender as CheckBox)?.Name == "chkboxTempFolder")
            //{
            //    ttFileSearch.SetToolTip(chkboxTempFolder, "Если включено, то из поиска исключаются все временные (Temp) папки");
            //}
            if ((sender as GroupBox)?.Name == "gboxOptimization")
            {
                ttFileSearch.SetToolTip(gboxOptimization, "Скорость: Значительно ускоряет поиск, но может потреблять много ОЗУ\r\n" +
                    "Ресурсы: Потребляет мало ОЗУ, но уходит очень много времени на поиск в файле");
            }
            if ((sender as RadioButton)?.Name == "rbtnSpeed")
            {
                ttFileSearch.SetToolTip(rbtnSpeed, "Значительно ускоряет поиск, но может потреблять много ОЗУ");
            }
            if ((sender as RadioButton)?.Name == "rbtnSaveResources")
            {
                ttFileSearch.SetToolTip(rbtnSaveResources, "Потребляет мало ОЗУ, но уходит очень много времени на поиск в файле");
            }
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
    }
}