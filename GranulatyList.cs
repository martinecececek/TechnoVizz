using System;
using System.Collections.Generic;
using System.Threading;
using Technovizz.Objekty;
using Excel = Microsoft.Office.Interop.Excel;

namespace Technovizz
{
    public partial class GranulatyList
    {
        private void List6_Startup(object sender, System.EventArgs e)
        {
        }

        public List<Granulaty> GetGranulaty()
        {

            Excel.Application excelApp = Globals.ThisWorkbook.Application;
            Excel.Worksheet worksheet = excelApp.ActiveSheet as Excel.Worksheet;

            var list = new List<Granulaty>();

            for (int i = 0; i < worksheet.Rows.Count; i++)
            {
                if (Cells[i, 1] == null && Cells[i, 2] == null && Cells[i, 3] == null)
                {
                    break;
                }

                Thread mainThread = Thread.CurrentThread;

                var slozeni = new List<String>();
                Thread getSlozeniThread = new Thread(() => { slozeni = GetSlozeni(i, 11); });

                getSlozeniThread.Start();

                var name = GetCellValue(worksheet, i, 1) ?? "|*|";
                var typ = GetCellValue(worksheet, i, 2) ?? "|*|";
                var xK = GetCellValue(worksheet, i, 3) ?? "|*|";
                var aktivni = GetCellValue(worksheet, i, 4) ?? "|*|";
                var vyrobce = GetCellValue(worksheet, i, 5) ?? "|*|";
                var pouziti = GetCellValue(worksheet, i, 6) ?? "|*|";
                var kombinace = GetCellValue(worksheet, i, 7) ?? "|*|";
                var cisteni = GetCellValue(worksheet, i, 8) ?? "|*|";
                var nevhodneKombinace = GetCellValue(worksheet, i, 9) ?? "|*|";
                var slozeniDle = GetCellValue(worksheet, i, 10) ?? "|*|";

                getSlozeniThread.Join();
                mainThread.Join();

                list.Add(new Granulaty(name, typ, xK, aktivni, vyrobce, pouziti, kombinace, cisteni, nevhodneKombinace, slozeniDle, slozeni));
            }

            return list;
        }

        private string GetCellValue(Excel.Worksheet worksheet, int row, int column)
        {
            var cellValue = worksheet.Cells[row, column].Value;
            return cellValue != null ? cellValue.ToString() : null;
        }

        public List<String> GetSlozeni(int currentRow, int startingCollumn)
        {
            Excel.Application excelApp = Globals.ThisWorkbook.Application;
            Excel.Worksheet worksheet = excelApp.ActiveSheet as Excel.Worksheet;

            var slozeniGranulatu = new List<String>();

            for (int i = startingCollumn; i < 28; i++)
            {
                slozeniGranulatu.Add(Cells[currentRow, i]);
            }

            return slozeniGranulatu;
        }


        private void List6_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Kód vygenerovaný Návrhářem VSTO

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(List6_Startup);
            this.Shutdown += new System.EventHandler(List6_Shutdown);
        }

        #endregion

    }
}
