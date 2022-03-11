using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.View.Menu;
using KasirTiketKereta.View.Menu.Pesan_Tiket;
using KasirTiketKereta.View.Menu.Reference;
using KasirTiketKereta.View.Menu.Tambah_Tiket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirTiketKereta
{
    public partial class MenuForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        private FrmTambahKeteranganTiket frmKeteranganTiket;
        private KeteranganTiketController keteranganTiketController;
        private TiketController tiketController;
        private GerbongController gerbongController;
        private PelangganController pelangganController;
        private FrmTambahGerbong frmGerbong;
        private FrmPesan frmPesan;
        private FrmTambahPelanggan frmPelanggan;
        private bool checking = false;
        public MenuForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            keteranganTiketController = new KeteranganTiketController();
            gerbongController = new GerbongController();
            tiketController = new TiketController();
            pelangganController = new PelangganController();
            Warna(GlobalVariable.id_tema); 
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //untuk dapat drag dengan custom
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage" )]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam,  int IParam);

        public void Warna(int idx)
        {
            pnlTitle.BackColor = Tema.ptc[idx];
            pnlTitle2.BackColor = Tema.ptc2[idx];
            panelMenu.BackColor = Tema.pmc[idx];
            btnPesan.ForeColor = Tema.fmu[idx];
            btnPesan.BackColor = Tema.pmc[idx];
            this.btnPesan.Image = Tema.gbtnPesan[idx];
            btnReferences.ForeColor = Tema.fmu[idx];
            btnReferences.BackColor = Tema.pmc[idx];
            this.btnReferences.Image = Tema.gbtnReferesi[idx];
            btnTambahTiket.BackColor = Tema.pmc[idx];
            btnTambahTiket.ForeColor = Tema.fmu[idx];
            this.btnTambahTiket.Image = Tema.gbtnTambahTiket[idx];
            btnLaporan.BackColor = Tema.pmc[idx];
            btnLaporan.ForeColor = Tema.fmu[idx];
            this.btnLaporan.Image = Tema.gbtnLaporan[idx];
            btnPengaturan.BackColor = Tema.pmc[idx];
            btnPengaturan.ForeColor = Tema.fmu[idx];
            this.btnPengaturan.Image = Tema.gbtnSettings[idx];
            lblTitle.ForeColor = Tema.fmu[idx];
            this.btnMinimize.Image = Tema.gbtnMinimizeSign[idx];
            this.btnMinimize.BackColor = Tema.ptc[idx];
            this.btnMaximize.Image = Tema.gbtnMinimize[idx];
            this.btnMaximize.BackColor = Tema.ptc[idx];
            this.btnClose.ForeColor = Tema.fmu[idx];
            this.btnClose.BackColor = Tema.ptc[idx];
            this.panelBackground.BackgroundImage = Tema.pbi[idx];

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Tema.bsc[GlobalVariable.id_tema];
                    currentButton.ForeColor = Tema.fmu[GlobalVariable.id_tema];
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = Tema.pmc[GlobalVariable.id_tema];
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Tema.pmc[GlobalVariable.id_tema];
                    previousBtn.ForeColor = Tema.fmu[GlobalVariable.id_tema];
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void CenterPanel()
        {
            foreach (Control childrenPanel in panelBackground.Controls)
            {
                childrenPanel.Left = (childrenPanel.Parent.Width - childrenPanel.Width) / 2;
                childrenPanel.Top = (childrenPanel.Parent.Height - childrenPanel.Height) / 2;
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != childForm)
            {
                if (childForm == frmKeteranganTiket)
                {
                    if (activeForm != null)
                    {
                        if (activeForm == frmPelanggan)
                        {
                            frmPesan.Close();
                            frmPelanggan.Close();
                        }
                        activeForm.Close();
                    }
                    ActivateButton(btnSender);
                    activeForm = childForm;
                    frmGerbong.TopLevel = false;
                    this.panelBackground.Controls.Add(frmGerbong);
                    frmKeteranganTiket.TopLevel = false;
                    this.panelBackground.Controls.Add(frmKeteranganTiket);
                    this.panelBackground.Tag = frmKeteranganTiket;
                    frmGerbong.Show();
                    frmKeteranganTiket.BringToFront();
                    frmKeteranganTiket.Show();
                    frmGerbong.OnSelesai += SelesaiEventHandler;
                    lblTitle.Text = frmKeteranganTiket.Text;
                }
                else if(childForm == frmPelanggan)
                {
                    if (activeForm != null)
                    {
                        if (activeForm == frmKeteranganTiket)
                        {
                            frmKeteranganTiket.Close();
                            frmGerbong.Close();
                        }
                        activeForm.Close();
                    }
                    ActivateButton(btnSender);
                    activeForm = childForm;
                    frmPesan.TopLevel = false;
                    this.panelBackground.Controls.Add(frmPesan);
                    frmPelanggan.TopLevel = false;
                    this.panelBackground.Controls.Add(frmPelanggan);
                    this.panelBackground.Tag = frmPelanggan;
                    frmPelanggan.BringToFront();
                    frmPelanggan.Show();
                    frmPesan.Show();
                    frmPesan.OnSelesai += SelesaiEventHandler;
                    lblTitle.Text = childForm.Text;
                }
                else
                {
                    if (activeForm != null)
                    {
                        if (activeForm == frmKeteranganTiket)
                        {
                            frmKeteranganTiket.Close();
                            frmGerbong.Close();
                        }
                        else if(activeForm == frmPelanggan)
                        {
                            frmPesan.Close();
                            frmPelanggan.Close();
                        }
                        activeForm.Close();
                    }
                    ActivateButton(btnSender);
                    activeForm = childForm;
                    childForm.TopLevel = false;
                    this.panelBackground.Controls.Add(childForm);
                    this.panelBackground.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                    lblTitle.Text = childForm.Text;
                }
            }
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("And yakin ingin keluar?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void InisialisasiPesanTiket()
        {
            frmPelanggan = new FrmTambahPelanggan(lblTitle);
            frmPesan = new FrmPesan(lblTitle);
            frmPelanggan.IsiFrmTetangga(frmPesan);
            frmPesan.IsiFrmTetangga(frmPelanggan);
        }

        private void InisialisasiTambahTiket()
        {
            frmGerbong = new FrmTambahGerbong(lblTitle, tiketController, gerbongController, keteranganTiketController);
            frmKeteranganTiket = new FrmTambahKeteranganTiket(lblTitle, keteranganTiketController);
            frmGerbong.IsiFormTetangga(frmKeteranganTiket);
            frmKeteranganTiket.IsiFrmTetangga(frmGerbong);
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (activeForm != frmPelanggan || activeForm == null)
            {
                this.panelBackground.Visible = false;
                InisialisasiPesanTiket();
                OpenChildForm(frmPelanggan, sender);
                CenterPanel();
                this.panelBackground.Visible = true;
                this.checking = true;
            }
        }
        private void SelesaiEventHandler()
        {
            activeForm.Close();
            DisableButton();
            lblTitle.Text = "HOME";
        }


        private void panelDesktopPanel_SizeChanged(object sender, EventArgs e)
        {
            if (checking)
            {
                this.panelBackground.Visible = false;
                CenterPanel();
                this.panelBackground.Visible = true;
            }
        }


        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnTambahTiket_Click(object sender, EventArgs e)
        {
            if (activeForm != frmKeteranganTiket || activeForm == null)
            {
                this.checking = true;
                this.panelBackground.Visible = false;
                InisialisasiTambahTiket();
                OpenChildForm(frmKeteranganTiket, sender);
                CenterPanel();
                this.panelBackground.Visible = true;
            }
        }

        private void btnReferences_Click(object sender, EventArgs e)
        {
            this.checking = false;
            this.panelBackground.Visible = false;
            FrmReference frmReference = new FrmReference();
            frmReference.OnSelesai += SelesaiEventHandler;
            frmReference.Dock = DockStyle.Fill;
            OpenChildForm(frmReference, sender);
            CenterPanel();
            this.panelBackground.Visible = true;
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            this.checking = false;
            this.panelBackground.Visible = false;
            FrmLaporan frmLaporan = new FrmLaporan();
            frmLaporan.OnSelesai += SelesaiEventHandler;
            frmLaporan.Dock = DockStyle.Fill;
            OpenChildForm(frmLaporan, sender);
            CenterPanel();
            this.panelBackground.Visible = true;
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            this.checking = true;
            this.panelBackground.Visible = false;
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.update += Warna;
            frmSettings.OnSelesai += SelesaiEventHandler;
            frmSettings.InisialisasiTema();
            OpenChildForm(frmSettings, sender);
            CenterPanel();
            this.panelBackground.Visible = true;
        }

        private void MenuForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.btnMaximize.Image = Tema.gbtnMaximize[GlobalVariable.id_tema];
            }
            else
            {
                this.btnMaximize.Image = Tema.gbtnMinimize[GlobalVariable.id_tema];
            }
        }
    }
}
