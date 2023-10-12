using System;
using System.Collections.Generic;
using System.Threading;
using Technovizz.Objekty;
using Excel = Microsoft.Office.Interop.Excel;

namespace Technovizz
{
    public partial class CisitceAktivatoryList
    {
        private void List4_Startup(object sender, System.EventArgs e)
        {
        }

        public List<CisticeAktovatory> GetGranulaty()
        {

            Excel.Application excelApp = Globals.ThisWorkbook.Application;
            Excel.Worksheet worksheet = excelApp.ActiveSheet as Excel.Worksheet;

            var list = new List<CisticeAktovatory>();

            for (int i = 0; i < worksheet.Rows.Count; i++)
            {
                if (Cells[i, 1] == null && Cells[i, 2] == null && Cells[i, 3] == null)
                {
                    break;
                }

                Thread mainThread = Thread.CurrentThread;

                var slozeni = new List<String>();
                Thread getSlozeniThread = new Thread(() => { slozeni = GetSlozeni(i, 7); });

                getSlozeniThread.Start();

                var name = GetCellValue(worksheet, i, 1) ?? "|*|";
                var aktivni = GetCellValue(worksheet, i, 2) ?? "|*|";
                var vyrobce = GetCellValue(worksheet, i, 3) ?? "|*|";
                var pouziti = GetCellValue(worksheet, i, 4) ?? "|*|";
                var nevhodneKombinace = GetCellValue(worksheet, i, 5) ?? "|*|";
                var slozeniDle = GetCellValue(worksheet, i, 6) ?? "|*|";

                getSlozeniThread.Join();
                mainThread.Join();

                list.Add(new CisticeAktovatory(name, aktivni, vyrobce, pouziti, nevhodneKombinace, slozeniDle, slozeni));
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

            for (int i = startingCollumn; i <= 18; i++)
            {
                slozeniGranulatu.Add(Cells[currentRow, i]);
            }

            return slozeniGranulatu;
        }
        private void List4_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Kód vygenerovaný Návrhářem VSTO

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(List4_Startup);
            this.Shutdown += new System.EventHandler(List4_Shutdown);
        }

        #endregion

    }
}
