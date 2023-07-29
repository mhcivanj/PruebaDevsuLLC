
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOMATION_E2E.Actions
{
    public class ReadFiles
    {
        public static (string, string) FilesExcel (string filePath)
        {
            String User = "";
            String Pass = "";
            SLDocument sl = new SLDocument(filePath);
                        
            int iRow = 2;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                User = sl.GetCellValueAsString(iRow, 1);
                Pass = sl.GetCellValueAsString(iRow, 2);           
                iRow++;
            }
            return (User, Pass); 
        }
    }
}
