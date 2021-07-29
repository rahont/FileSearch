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

        /// <summary>
        /// Возвращает номер версии приложения
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>1: Major, 2: Major + Minor, 3: Major + Minor + Build, 4: Major + Minor + Build + Revision</returns>
        public static string AppVersion(short amount = 2)
        {
            //Присваиваем Major
            string result = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString();

            if (amount < 1)
                result = ".!. :P";
            else
            {
                if (amount > 1)
                {
                    //Присваиваем Minor
                    result += "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();

                    if (amount > 2)
                    {
                        //Присваиваем Build
                        result += "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();

                        if (amount > 3)
                        {
                            //Присваиваем Revision
                            result += "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
                        }
                    }
                }
            }

            return result;
        }
    }
}
