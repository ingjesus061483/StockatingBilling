using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
namespace DataAccess.Repositories
{
    public class ExcelRepository
    {       
        Excel.Application ExcelApp;
        public ExcelRepository()
        {

        }   
        Excel.Worksheet GetSheet(string Name, Excel.Application ExcelApp, string hoja)
        {
            Excel.Worksheet WorkSheet = (Excel.Worksheet)ExcelApp.Sheets[hoja];
            WorkSheet.Name = Name ;
            WorkSheet.Cells[1, 1] = Name;
            WorkSheet.Range["A1:H1"].MergeCells = true;   // MERGE CELLS OF THE HEADER.
            return WorkSheet;
        }
        void SetColumnSheet(Array array , Excel.Worksheet WorkSheet)
        {
            int iRowCnt = 2;
            int col = 1;
            object obj = array.GetValue(0);
            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                WorkSheet.Cells[iRowCnt, col] = property.Name; // column.ColumnName;
                col += 1;
            }
        }
        void SetRowsSheet(Array array , Excel.Worksheet WorkSheet)
        {
            int iRowCnt = 3;
            foreach (object obj3 in array)
            {
                int  col = 1;
                foreach (PropertyInfo property in obj3.GetType().GetProperties())
                {                    
                    WorkSheet.Cells[iRowCnt, col] = property.GetValue(obj3); // column.ColumnName;
                    col += 1;
                }
                iRowCnt += 1;
            }
        }        
        public void Export( Dictionary< string, Array > values)
        {
            ExcelApp = new Excel.Application();
            string hoja = "Hoja";
            Excel.Worksheet WorkSheet;
            ExcelApp.Workbooks.Add();
            int cont  = 1;
            foreach (var item in values)
            {
                if (item.Value.Length > 0)
                {                    
                    WorkSheet = GetSheet(item.Key, ExcelApp, hoja + cont.ToString());
                    SetColumnSheet(item.Value, WorkSheet);
                    SetRowsSheet(item.Value, WorkSheet);
                    cont++;
                    ExcelApp.Sheets.Add();
                }                
            }
            WorkSheet = ExcelApp.Sheets[hoja + cont.ToString()];
            WorkSheet.Delete();
            ExcelApp.Visible = true;
            ExcelApp = null;
        }
    }
}
