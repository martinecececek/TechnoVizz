using Microsoft.VisualStudio.Tools.Applications.Runtime;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Technovizz
{
    public partial class CisitceAktivatory
    {
        private void List4_Startup(object sender, System.EventArgs e)
        {
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
