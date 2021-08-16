using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpCompress.Readers;
using SharpCompress.Archives.Rar;
using SharpCompress.Archives.Zip;
using SharpCompress.Archives.SevenZip;
using System.IO;

namespace FileSearch.SearchInFiles
{
    class ArchiveWork
    {
        public List<string> CheckInArchive(string pathFile, string searchText, out string exception)
        {
            exception = null;
            List<string> result = null;

            Stream streamArchive = File.OpenRead(pathFile);
            var reader = ReaderFactory.Open(streamArchive);
            WordWork wordW = new WordWork();

            try
            {
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        //Поиск текста в имени файла/папки
                        if (CheckInFileName(reader.Entry.Key, searchText))
                        {
                            result.Add("В архиве: " + pathFile + reader.Entry.Key);
                        }
                        else if (CheckWordExtension(reader.Entry.Key) == "word")
                        {
                            //Если вернется true, то добавить путь файла в List
                            if (wordW.CheckInStreamWordFile(reader.OpenEntryStream(), searchText, out string exceptionWord))
                                result.Add("В архиве: " + pathFile + reader.Entry.Key);
                            //Если возвращается false, то проверяем на наличие исключения
                            else if (exception != null)
                                result.Add(exception);
                        }
                        else if (CheckExcelExtension(reader.Entry.Key) == "excel")
                        {

                        }


                        //System.Windows.Forms.MessageBox.Show(reader.Entry.Key);

                        //reader.OpenEntryStream();

                        //if (CheckInStreamWordFile(reader.OpenEntryStream()))
                        //{

                        //}

                        //Console.WriteLine(reader.Entry.Key);
                        //reader.WriteEntryToDirectory(@"C:\temp", new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                    }
                }
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }

            return result;
        }

        private string CheckWordExtension(string file)
        {
            string result = "non";
            string extension = Path.GetExtension(file);

            string[] wordFileExtension = { ".doc", ".docx", ".docm", ".rtf" };

            foreach (var item in wordFileExtension)
            {
                if (item == extension)
                {
                    result = "word";
                    return result;
                }
            }

            return result;
        }

        private string CheckExcelExtension(string file)
        {
            string result = "non";
            string extension = Path.GetExtension(file);

            string[] excelFileExtension = { ".xls", ".xlsx", ".xlsm", ".xlsb" };

            foreach (var item in excelFileExtension)
            {
                if (item == extension)
                {
                    result = "excel";
                    return result;
                }
            }

            return result;
        }

        private bool CheckInFileName(string fileName, string searchText)
        {
            //Поиск текста в имени файла/папки
            bool result = (fileName.ToLower().IndexOf(searchText.ToLower()) > -1);
            return result;
        }
    }
}
