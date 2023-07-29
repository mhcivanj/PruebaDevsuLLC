
using System;
using System.Data;

namespace AUTOMATION.Tasks
{
    public class LoadExcel
    {
        public static Object[] LoadFileExcel(string filePath)
        {
            DataSet values = AUTOMATION_E2E.Actions.ReadFileExcel.ExcelFile(filePath);

            DataTable table = values.Tables[0];
            DataRow row = table.Rows[1];
           
            
            //- Crear Array
            Object [] Datos = new Object[table.Columns.Count];

            for (int r = 1; r < table.Rows.Count; r++)
            {
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    //- Guardar la Columna Nombre el el Arreglo
                    Datos[c] = table.Rows[r][c].ToString();
                }
            }

            return Datos;

        }

    }
}
