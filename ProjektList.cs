using System.Collections.Generic;
using System.Threading.Tasks;
using Technovizz.Objekty;
using Excel = Microsoft.Office.Interop.Excel;

namespace Technovizz
{
    public partial class ProjektList
    {
        private void List3_Startup(object sender, System.EventArgs e)
        {
            Excel.Workbook wb = new Excel.Workbook();
            Excel.Worksheet ws = wb.Worksheets[1];

            ws.Name = "Projekty";
        }

        public async Task<List<Project>> GetProjektsAsync()
        {
            List<Project> list = new List<Project>();

            Excel.Application excelApp = Globals.ThisWorkbook.Application;
            Excel.Worksheet worksheet = excelApp.ActiveSheet as Excel.Worksheet;

            int i = 1;

            while (worksheet.Cells[i, 1] != null && worksheet.Cells[i, 2] != null && worksheet.Cells[i, 3] != null)
            {

                var TL = worksheet.Cells[i, 1];
                if (worksheet.Cells[i, 1] == string.Empty)
                {
                    TL = "|*|";
                }

                var name = worksheet.Cells[i, 2];
                if (worksheet.Cells[i, 2] == string.Empty)
                {
                    name = "|*|";
                }

                /*
                 TODO:
                add some sort of refference on material object to add them to project
                 */

                var material = new Material("dsa", "ads", "aads");


                var ZkracenyPopis = worksheet.Cells[i, 3];
                if (worksheet.Cells[i, 3] == string.Empty)
                {
                    ZkracenyPopis = "|*|";
                }

                var sklo = worksheet.Cells[i, 4];
                if (worksheet.Cells[i, 4] == string.Empty)
                {
                    sklo = "|*|";
                }

                var temp = worksheet.Cells[i, 5];
                if (worksheet.Cells[i, 5] == string.Empty)
                {
                    temp = "|*|";
                }

                var trh = worksheet.Cells[i, 6];
                if (worksheet.Cells[i, 6] == string.Empty)
                {
                    trh = "|*|";
                }

                var imds = worksheet.Cells[i, 7];
                if (worksheet.Cells[i, 7] == string.Empty)
                {
                    imds = "|*|";
                }

                list.Add(new Project(TL, name, material, ZkracenyPopis, sklo, temp, trh, imds));
            }

            return list;
        }

        private void List3_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Kód vygenerovaný Návrhářem VSTO

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(List3_Startup);
            this.Shutdown += new System.EventHandler(List3_Shutdown);
        }

        #endregion

    }
}
