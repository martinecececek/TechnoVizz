using System.Collections.Generic;
using System.Threading.Tasks;
using Technovizz.Objekty;
using Excel = Microsoft.Office.Interop.Excel;

namespace Technovizz
{
    public partial class MaterialList
    {
        private void List2_Startup(object sender, System.EventArgs e)
        {
        }

        public async Task<List<Material>> GetMaterials()
        {
            List<Material> list = new List<Material>();

            Excel.Application excelApp = Globals.ThisWorkbook.Application;
            Excel.Worksheet worksheet = excelApp.ActiveSheet as Excel.Worksheet;

            int i = 1;

            while (worksheet.Cells[i, 1] != null && worksheet.Cells[i, 2] != null && worksheet.Cells[i, 3] != null)
            {

                var sap = worksheet.Cells[i, 1];
                if (worksheet.Cells[i, 1] == string.Empty)
                {
                    sap = "|*|";
                }

                var name = worksheet.Cells[i, 2];
                if (worksheet.Cells[i, 2] == string.Empty)
                {
                    name = "|*|";
                }

                var typ = worksheet.Cells[i, 3];
                if (worksheet.Cells[i, 3] == string.Empty)
                {
                    typ = "|*|";
                }

                list.Add(new Material(sap, name, typ));
            }

            return list;
        }

        private void List2_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Kód vygenerovaný Návrhářem VSTO

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(List2_Startup);
            this.Shutdown += new System.EventHandler(List2_Shutdown);
        }

        #endregion

    }
}
