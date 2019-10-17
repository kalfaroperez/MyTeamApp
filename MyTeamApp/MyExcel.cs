using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyTeamApp
{
    class MyExcel
    {
        public static string DB_PATH = @"";
        public static BindingList<Votante> EmpList = new BindingList<Votante>();
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
        private static int lastRow = 0;
        public static void InitializeExcel()
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explict cast is not required here
            lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
        }
        public static BindingList<Votante> ReadMyExcel()
        {
            EmpList.Clear();
            for (int index = 2; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "E" + index.ToString()).Cells.Value;
                EmpList.Add(new Votante
                {
                    Nombres = MyValues.GetValue(1, 1).ToString(),
                    Apellidos = MyValues.GetValue(1, 2).ToString(),
                    Cedula_ID = MyValues.GetValue(1, 3).ToString(),
                    Candidato = MyValues.GetValue(1, 4).ToString(),
                    Fecha = Convert.ToDateTime(MyValues.GetValue(1, 5))
                });
            }
            return EmpList;
        }
        public static void WriteToExcel(Votante emp)
        {
            try
            {
                bool existe = false;
                for (int index = 2; index <= lastRow; index++)
                {
                    System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "E" + index.ToString()).Cells.Value;
                    string cedula = MyValues.GetValue(1, 3).ToString();
                    if (emp.Cedula_ID == cedula)
                    {
                        existe = true;
                    }
                }
                if (existe)
                {
                    MessageBox.Show("La cedula ingresada ya Existe", "Alerta!!..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lastRow += 1;
                    MySheet.Cells[lastRow, 1] = emp.Nombres;
                    MySheet.Cells[lastRow, 2] = emp.Apellidos;
                    MySheet.Cells[lastRow, 3] = emp.Cedula_ID;
                    MySheet.Cells[lastRow, 4] = emp.Candidato;
                    MySheet.Cells[lastRow, 5] = DateTime.Now;
                    EmpList.Add(emp);
                    MyBook.Save();
                    MessageBox.Show("Details were successfully added to the excel !!", "Success..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            { }

        }

        public static List<Votante> FilterEmpList(string searchValue, string searchExpr)
        {
            List<Votante> FilteredList = new List<Votante>();
            switch (searchValue.ToUpper())
            {
                case "Nombres":
                    FilteredList = EmpList.ToList().FindAll(emp => emp.Nombres.ToLower().Contains(searchExpr));
                    break;
                case "Apellidos":
                    FilteredList = EmpList.ToList().FindAll(emp => emp.Apellidos.ToLower().Contains(searchExpr));
                    break;
                case "Cedula":
                    FilteredList = EmpList.ToList().FindAll(emp => emp.Cedula_ID.ToLower().Contains(searchExpr));
                    break;
                case "Candidato":
                    FilteredList = EmpList.ToList().FindAll(emp => emp.Candidato.ToLower().Contains(searchExpr));
                    break;
                default:
                    break;
            }
            return FilteredList;
        }
        public static void CloseExcel()
        {
            MyBook.Saved = true;
            MyApp.Quit();

        }

    }

}
