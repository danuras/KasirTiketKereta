using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Asset_Code
{
    public class Tema
    {

        /// <summary>
        ///warna pada panel title menu utama
        /// </summary>
        public static Color[] ptc = { 
            Color.FromArgb(50, 0, 100),
            Color.FromArgb(4, 102, 200),
            Color.FromArgb(0,0,0),
        };

        /// <summary>
        ///warna pada panel title ke 2 menu utama
        /// </summary>
        public static Color[] ptc2 =
        {
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 24, 69),
            Color.FromArgb(14, 80, 14),
        };
        /// <summary>
        /// warna pada list button menu utama
        /// </summary>
        public static Color[] pmc =
        {
            Color.FromArgb(20, 20, 20),
            Color.FromArgb(151, 157, 172),
            Color.FromArgb(0,0,0),
        };
        /// <summary>
        /// warna button ketika di klik
        /// </summary>
        public static Color[] bsc =
        {
            Color.FromArgb(50, 0, 100),
            Color.FromArgb(4, 102, 200),
            Color.FromArgb(20, 148, 20),
        };
        /// <summary>
        /// gambar pada panelBackground
        /// </summary>
        public static Image[] pbi =
        {
            Properties.Resources.DarkPurple1,
            Properties.Resources.light_background,
            Properties.Resources.Hacker,
        };
        /// <summary>
        /// gambar pada form mini background
        /// </summary>
        public static Image[] pbim =
        {
            Properties.Resources.DarkPurple,
            Properties.Resources.Light,
            Properties.Resources.hacker_mini,
        };
        /// <summary>
        /// warna font di menu utama
        /// </summary>
        public static Color[] fmu =
        {
            Color.FromArgb(220,220,220),
            Color.FromArgb(0,0,0),
            Color.FromArgb(255,255,255),
        };

        /// <summary>
        /// warna font di form Child
        /// </summary>
        public static Color[] fcfc =
        {
            Color.FromArgb(220,220,220),
            Color.FromArgb(0,0,0),
            Color.FromArgb(20,148,20),
        };

        /// <summary>
        /// warna panel/form child
        /// </summary>
        public static Color[] pcc = {
            Color.FromArgb(180, 0, 0, 0),
            Color.FromArgb(180, 255, 255, 255),
            Color.FromArgb(180, 0,0,0),
        };
        /// <summary>
        /// warna panel untuk membungkus inputan
        /// </summary>
        public static Color[] ppc = {
            Color.FromArgb(180, 50, 0, 100),
            Color.FromArgb(100, 255, 255, 255),
            Color.FromArgb(30, 14,107,14),
        };
        /// <summary>
        /// warna untuk button
        /// </summary>
        public static Color[] ob =
        {
            Color.FromArgb(255,255,255),
            Color.FromArgb(255,255,255),
            Color.FromArgb(180, 14,107,14),
        };
        /// <summary>
        /// warna untuk listview,
        /// </summary>
        public static Color[] ol =
        {
            Color.FromArgb(255,255,255),
            Color.FromArgb(255,255,255),
            Color.FromArgb(0,0,0),
        };
        /// <summary>
        /// warna untuk textbox
        /// </summary>
        public static Color[] ot =
        {
            Color.FromArgb(255,255,255),
            Color.FromArgb(255,255,255),
            Color.FromArgb(14,107,14),
        };
        /// <summary>
        /// warna untuk font yang ada di button
        /// </summary>
        public static Color[] ofb =
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(0,0,0),
            Color.FromArgb(255,255,255),
        };
        /// <summary>
        /// warna untuk font yang ada di listview, dan lain-lain
        /// </summary>
        public static Color[] ofl =
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(0,0,0),
            Color.FromArgb(20,148,20),
        };
        /// <summary>
        /// warna untuk font yang ada di textBox
        /// </summary>
        public static Color[] oft =
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(0,0,0),
            Color.FromArgb(255,255,255),
        };
        /// <summary>
        /// gambar untuk btnPesan
        /// </summary>
        public static Image[] gbtnPesan =
        {
            Properties.Resources.payment_white,
            Properties.Resources.payment_black,
            Properties.Resources.payment_white,
        };
        /// <summary>
        /// gambar untuk btnReferensi
        /// </summary>
        public static Image[] gbtnReferesi =
        {
            Properties.Resources.reference_white,
            Properties.Resources.reference_black,
            Properties.Resources.reference_white,
        };
        /// <summary>
        /// gambar untuk btnMinimize
        /// </summary>
        public static Image[] gbtnMinimize =
        {
            Properties.Resources.minimize_white,
            Properties.Resources.minimize_black,
            Properties.Resources.minimize_white,
        };
        /// <summary>
        /// gambar untuk btnMaximize
        /// </summary>
        public static Image[] gbtnMaximize =
        {
            Properties.Resources.maximize_white,
            Properties.Resources.maximize_black,
            Properties.Resources.maximize_white,
        };
        /// <summary>
        /// gambar untuk btnMinimizeSign
        /// </summary>
        public static Image[] gbtnMinimizeSign =
        {
            Properties.Resources.minimize_sign_white,
            Properties.Resources.minimize_sign_black,
            Properties.Resources.minimize_sign_white,
        };
        /// <summary>
        /// gambar untuk btnLaporan
        /// </summary>
        public static Image[] gbtnLaporan =
        {
            Properties.Resources.laporan_white,
            Properties.Resources.laporan_black,
            Properties.Resources.laporan_white,
        };
        /// <summary>
        /// gambar untuk btnTambahTiket
        /// </summary>
        public static Image[] gbtnTambahTiket =
        {
            Properties.Resources.tiket_white,
            Properties.Resources.tiket_black,
            Properties.Resources.tiket_white,
        };
        /// <summary>
        /// gambar untuk btnReferensi
        /// </summary>
        public static Image[] gbtnSettings =
        {
            Properties.Resources.settings_white,
            Properties.Resources.settings_black,
            Properties.Resources.settings_white,
        };
        /// <summary>
        /// gambar untuk btnReferensi
        /// </summary>
        public static Image[] gbtnExit =
        {
            Properties.Resources.exit_white,
            Properties.Resources.exit_black,
            Properties.Resources.exit_white,
        };
    }
}
