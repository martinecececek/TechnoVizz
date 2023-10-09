using Microsoft.VisualStudio.Tools.Applications.Runtime;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Technovizz
{
    public partial class KluzkyLak
    {
        private void List5_Startup(object sender, System.EventArgs e)
        {
        }

        private void List5_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Kód vygenerovaný Návrhářem VSTO

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(List5_Startup);
            this.Shutdown += new System.EventHandler(List5_Shutdown);
        }

        #endregion

    }
}
