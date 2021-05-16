using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch
{
    static class StaticMethods
    {
        /// <summary>
        /// Проверяет наличие DLL
        /// </summary>
        /// <returns>Возвращает List<string> с именами отсутствующих DLL</returns>
        public static List<string> CheckDLL()
        {
            string dllPath = Environment.CurrentDirectory + "\\lib";

            string[] dllArr =
            {
                "Aspose.Words.dll",
                "Microsoft.Bcl.AsyncInterfaces.dll",
                "System.Runtime.CompilerServices.Unsafe.dll",
                "System.Threading.Tasks.Extensions.dll"
            };

            List<string> result = new List<string>();
            //int tmp = 0;

            foreach (var item in dllArr)
            {
                if (!File.Exists(Path.Combine(dllPath, item)))
                    result.Add(item);
            }

            return result;
        }
    }
}
