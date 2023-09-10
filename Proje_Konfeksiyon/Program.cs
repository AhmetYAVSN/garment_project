using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Konfeksiyon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GirisPanel frm = new GirisPanel();

            DialogResult dr = frm.ShowDialog();
            if (dr != DialogResult.OK)
                return;

            Application.Run(new GirisPanel());
        }
    }
}
