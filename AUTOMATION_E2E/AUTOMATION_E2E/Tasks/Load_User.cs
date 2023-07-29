using AUTOMATION_E2E.Actions;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOMATION_E2E.Tasks
{
    public class Load_User
    {
        public static (string, string) FilesXLSX(string filePath)
        {
            var(User, Pass) = ReadFiles.FilesExcel(filePath);
            return (User, Pass);
        }
    }
}
