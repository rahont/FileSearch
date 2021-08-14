using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch
{
    class ExcelWork
    {
        /// <summary>
        /// Ищет совпадение в Excel файле. 
        /// </summary>
        /// <param name="findText">Искомое слово/фраза в файле.</param>
        /// <param name="exception">Возвращает исключение. Изначально = null.</param>
        /// <param name="filePath">Полный путь к файлу.</param>
        /// <returns>Возвращает true если находит совпадение. out - возвращает исключение.</returns>
        public bool CheckInExcelFile(string filePath, Object findText, out string exception)
        {
            bool result = false;
            exception = null;

            try
            {
                Aspose.Cells.Workbook wb = new Aspose.Cells.Workbook(filePath);

                for (int i = 0; i < wb.Worksheets.Count; i++)
                {
                    if (wb.Worksheets[i].Cells.Find(findText, null) != null)
                        result = true;
                    //var ewq = wb.Worksheets[i].Cells.Find(findText, null);
                }
            }
            catch (Exception ex)
            {
                //HResult == -2147024864 - файл используется в другом процессе
                if (ex.HResult == -2147024864) exception = ex.Message;

                //HResult == -2146233088 - файл используется в другом процессе
                //if (ex.HResult == -2146233088) ;
            }

            return result;
        }
    }
}
