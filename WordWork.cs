using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace FileSearch
{
    class WordWork
    {
        private Word.Application wordApp;
        private Object saveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
        private readonly string filePath;

        /// <summary>
        /// Запускает экземпляр winword.exe для последующей работы в классе
        /// </summary>
        public WordWork()
        {
            wordApp = new Word.Application();
            wordApp.Visible = false;
        }

        /// <summary>
        /// Запускает экземпляр winword.exe для последующей работы в классе
        /// </summary>
        /// <param name="filePath">Полный путь к файлу.</param>
        public WordWork(string filePath)
        {
            this.filePath = filePath;
            wordApp = new Word.Application();
            wordApp.Visible = false;
        }

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

            Word.Document doc;
            try
            {
                doc = wordApp.Application.Documents.OpenNoRepairDialog(filePath, ReadOnly: true);

                foreach (Word.Range range in doc.StoryRanges)
                {
                    Word.Find find = range.Find;
                    if (find.Execute(ref findText))
                    {
                        result = true;
                    }
                }
            }
            catch (NullReferenceException)
            {
                exception = "Скорее всего этот файл недоступен, возможно не хватает прав";
            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() != "System.Runtime.InteropServices.COMException")
                    exception = ex.Message;
            }

            return result;
        }

        public void WordQuit()
        {
            try
            {
                wordApp?.Quit(ref saveChanges);
            }
            catch (Exception ex)
            {
                string mes = "При закрытии процесса WINWORD.EXE произошла ошибка.\n" +
                    "После завершения поиска закрой процесс вручную (или не закрывай, как хочешь).";
                System.Windows.Forms.MessageBox.Show(ex.GetType().ToString() + "\r\n" + mes, ex.GetType().ToString(), System.Windows.Forms.MessageBoxButtons.OK);
            }
            
        }
    }
}