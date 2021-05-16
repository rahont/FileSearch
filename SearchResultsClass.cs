﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearch
{
    class SearchResultsClass
    {
        private Label lblActiveFileSearch;
        private Form mainForm;
        private string tbWhatSearchText;
        public bool IsStopSearch = false;

        delegate void DelActiveFileSearch(string filePath);

        /// <summary>
        /// MyCtor
        /// </summary>
        /// <param name="lblActiveFileSearch">для вывода текущего файла в поиске</param>
        /// <param name="mainForm">основная форма, для работы контролов из своих потоков</param>
        /// <param name="tbWhatSearchText">искомое имя/фраза</param>
        public SearchResultsClass(Label lblActiveFileSearch, Form mainForm, string tbWhatSearchText)
        {
            this.lblActiveFileSearch = lblActiveFileSearch;
            this.mainForm = mainForm;
            this.tbWhatSearchText = tbWhatSearchText;
        }

        private void MethActiveFileSearch(string filePath)
        {
            lblActiveFileSearch.Text = filePath;
        }

        public async IAsyncEnumerable<string> SearchResults(string namePC)
        {
            List<string> result = new List<string>();
            WordWork wordW = new WordWork();

            //Если первые 2 символа не \\, то добавить
            if (namePC.Substring(0, 2) != @"\\") namePC = @"\\" + namePC;

            string[] fileExtension = { ".doc", ".docx", ".docm", ".rtf" };

            var q = SafeEnumerateFiles(namePC, "*.*", SearchOption.AllDirectories);

            DelActiveFileSearch delAFS = new DelActiveFileSearch(MethActiveFileSearch);

            await Task.Run(() =>
            {
                foreach (var filePath in q)
                {
                    if (IsStopSearch) break;

                    //Устанавливает в Label текущий файл поиска
                    mainForm.Invoke(delAFS, filePath);

                    if (filePath.ToLower().IndexOf(tbWhatSearchText.ToLower()) > -1)
                        result.Add(filePath);

                    foreach (var fileExt in fileExtension)
                    {
                        //Если вернется true, то пропустить поиск в файле
                        if (SkipCheckInFile(fileExt)) continue;

                        //Если расширение файла = расширение цикла
                        if (Path.GetExtension(filePath) == fileExt)
                        {
                            //Если вернется true, то добавить путь файла в List
                            if (wordW.CheckInWordFile(filePath, tbWhatSearchText, out string exception))
                                result.Add("НАЙДЕНО СОВПАДЕНИЕ В ФАЙЛЕ: " + filePath);
                            //Если возвращается false, то проверяем на наличие исключения
                            else if (exception != null)
                                result.Add(exception);
                        }
                    }
                }
            });

            //return result;
            foreach (string item in result.Reverse<string>())
            {
                yield return item;
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
                        //if (dirs.Count == 1)
                        //    files.Add("Нет доступа к " + currentDirPath);
                        continue;
                    }
                    catch (DirectoryNotFoundException)
                    {
                        continue;
                    }
                    catch (ArgumentException ex)
                    {
                        //MessageBox.Show(ex.ToString(), "ArgumentException (SafeEnumerateFiles)");
                        break;
                    }
                    catch (IOException)
                    {
                        continue;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message, "Exception (SafeEnumerateFiles)");
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

        private bool SkipCheckInFile(string fileExtension)
        {
            bool result = false;

            if (fileExtension == ".doc")
                if (Properties.Settings.Default.chkbDoc)
                    result = true;

            if (fileExtension == ".docx")
                if (Properties.Settings.Default.chkbDocx)
                    result = true;

            if (fileExtension == ".docm")
                if (Properties.Settings.Default.chkbDocm)
                    result = true;

            if (fileExtension == ".rtf")
                if (Properties.Settings.Default.chkbRtf)
                    result = true;

            return result;
        }

        private bool SkipFolder(string subDirPath)
        {
            //Исключает из поиска указанные папки
            if (Path.GetFileName(subDirPath).ToLower() == "Windows".ToLower())
                if (Properties.Settings.Default.chkbWindows) return true;
            if (Path.GetFileName(subDirPath).ToLower() == "$Recycle.Bin".ToLower())
                if (Properties.Settings.Default.chkbRecycle) return true;
            if (Path.GetFileName(subDirPath).ToLower() == "Temp".ToLower())
                if (Properties.Settings.Default.chkbTemp) return true;
            if (Path.GetFileName(subDirPath).ToLower() == "Program Files".ToLower())
                if (Properties.Settings.Default.chkbProgram) return true;
            if (Path.GetFileName(subDirPath).ToLower() == "Program Files (x86)".ToLower())
                if (Properties.Settings.Default.chkbProgram86) return true;

            //Исключает из поиска указанные пользователем папки
            string[] excepFolders = Properties.Settings.Default.anyFolders.Split(';');
            if (excepFolders[0] == string.Empty) return false;
            foreach (var item in excepFolders)
            {
                string tmpItem = item.Trim();
                if (Path.GetFileName(subDirPath).ToLower() == tmpItem.ToLower())
                    return true;
            }

            return false;
        }
    }
}