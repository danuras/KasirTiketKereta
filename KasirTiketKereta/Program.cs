using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.View.Menu.Pesan_Tiket;
using KasirTiketKereta.View.Menu.Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirTiketKereta
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalVariable.id_tema = Properties.Settings.Default.idx_tema;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Properties.Settings.Default.isFirst = true;
            Properties.Settings.Default.Save();*/
            /*Penggunaan Properties Settings untuk menentukan 
              apakah user sudah pernah membuat akun admin atau belum*/
            if (Properties.Settings.Default.isFirst)
            {
                //Form pertama yang dibuka saat user belum pernah membuat user admin
                Application.Run(new FrmFirstLogin());
            }
            else
            {
                //Form pertama yang dibuka saat user sudah pernah membuat  user admin
                Application.Run(new FrmLogin());
            }
        }
    }
}
