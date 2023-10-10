using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Technovizz.Objekty;
using Excel = Microsoft.Office.Interop.Excel;

namespace Technovizz
{
    public partial class MaterialList
    {
        private void List2_Startup(object sender, System.EventArgs e) { }

        public async Task<List<Material>> GetMaterials()
        {

            //declare the list where the metod's are placed so i can work with data in it
            Excel.Application excelApp = Globals.ThisWorkbook.Application;
            Excel.Worksheet worksheet = excelApp.ActiveSheet as Excel.Worksheet;

            //get parametr of number where to end iterarion and where start another thread iteration
            int iterateTo = Columns.Count / 2;

            //create and get ready all the threads
            List<Material> materials1 = new List<Material>();
            Thread getData1 = new Thread(() => { materials1 = GetData(1, iterateTo); });

            List<Material> materials2 = new List<Material>();
            Thread getData2 = new Thread(() => { materials2 = GetData(iterateTo, Columns.Count); });


            //start thread's and wait to complete them
            getData1.Start();
            getData2.Start();

            getData1.Join();
            getData2.Join();

            //combine two mateials toggether so i can return the list of materials
            List<Material> list = materials1.Concat(materials2).ToList();

            return list;
        }

        private List<Material> GetData(int iterateTo, int start)
        {
            Excel.Application excelApp = Globals.ThisWorkbook.Application;
            Excel.Worksheet worksheet = excelApp.ActiveSheet as Excel.Worksheet;

            List<Material> list = new List<Material>();

            for (int i = start; i <= iterateTo; i++)
            {
                if (worksheet.Cells[i, 1] == null && worksheet.Cells[i, 2] == null && worksheet.Cells[i, 3] == null)
                {
                    break;
                }

                var sap = worksheet.Cells[i, 1];
                if (sap == string.Empty)
                {
                    sap = "|*|";
                }

                var name = worksheet.Cells[i, 2];
                if (name == string.Empty)
                {
                    name = "|*|";
                }

                var typ = worksheet.Cells[i, 3];
                if (typ == string.Empty)
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
