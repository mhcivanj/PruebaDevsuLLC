
using ExcelDataReader;
using System.Data;
using System.IO;

namespace AUTOMATION_E2E.Actions
{

    public class ReadFileExcel
    {
        public static DataSet ExcelFile(string filePath)
        {
            FileStream fStream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(fStream);
            DataSet resultDataSet = excelDataReader.AsDataSet();
            excelDataReader.Close();

            return (resultDataSet);
        }
 
    }

}
