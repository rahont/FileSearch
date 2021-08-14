using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;

namespace FileSearch
{
    class WordWork
    {
        /// <summary>
        /// Ищет совпадение в Word файле. 
        /// </summary>
        /// <param name="findText">Искомое слово/фраза в файле.</param>
        /// <param name="exception">Возвращает исключение. Изначально = null.</param>
        /// <param name="filePath">Полный путь к файлу.</param>
        /// <returns>Возвращает true если находит совпадение. out - возвращает исключение.</returns>
        public bool CheckInWordFile(string filePath, Object findText, out string exception)
        {
            bool result = false;
            exception = null;

            try
            {
                Document doc = new Document(filePath);

                string strSearch = findText.ToString();

                string docText = doc.GetText().Substring(80);
                docText = docText.Substring(0, docText.Length - 142);

                result = docText.IndexOf(strSearch, StringComparison.OrdinalIgnoreCase) > -1;
            }
            //catch (IOException ex)
            //{
            //    //HResult == -2147024864 - файл используется в другом процессе
            //    if (ex.HResult == -2147024864) exception = ex.Message;
            //}
            catch (Exception ex)
            {
                //HResult == -2147024864 - файл используется в другом процессе
                if (ex.HResult == -2147024864) exception = ex.Message;

                //HResult == -2146233088 - файл используется в другом процессе
                //if (ex.HResult == -2146233088) ;
            }

            return result;
        }

        /// <summary>
        /// Ищет совпадение в Word файле. 
        /// </summary>
        /// <param name="findText">Искомое слово/фраза в файле.</param>
        /// <param name="exception">Возвращает исключение. Изначально = null.</param>
        /// <param name="filePath">Полный путь к файлу.</param>
        /// <returns>Возвращает true если находит совпадение. out - возвращает исключение.</returns>
        public bool CheckInStreamWordFile(Stream entryStream, Object findText, out string exception)
        {
            bool result = false;
            exception = null;

            try
            {
                Document doc = new Document(entryStream);

                string strSearch = findText.ToString();

                string docText = doc.GetText().Substring(80);
                docText = docText.Substring(0, docText.Length - 142);

                result = docText.IndexOf(strSearch, StringComparison.OrdinalIgnoreCase) > -1;
            }
            catch (Exception ex)
            {
                //HResult == -2147024864 - файл используется в другом процессе
                if (ex.HResult == -2147024864) exception = ex.Message;
            }

            return result;
        }
    }
}