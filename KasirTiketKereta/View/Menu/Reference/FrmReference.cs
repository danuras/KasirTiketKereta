using KasirTiketKereta.Asset_Code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmReference : Form
    {

        public delegate void OnSelesaiEventHandler();
        public event OnSelesaiEventHandler OnSelesai;
        private Form activeForm;
        public FrmReference()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            GlobalVariable.isReference = true;
            cmbPilihReference.SelectedIndex = 0;
            Tampilan();
        }
        private void OpenChildForm(Form childForm)
        {
           
            if (activeForm != null)
            {
                 activeForm.Close();
            }
             activeForm = childForm;
             childForm.TopLevel = false;
             childForm.Dock = DockStyle.Fill;
             this.pnlReference.Controls.Add(childForm);
             this.pnlReference.Tag = childForm;
             childForm.BringToFront();
             childForm.Show();
             lblJudul.Text = childForm.Text;
            cmbPilihReference.BringToFront();
            btnSelesai.BringToFront();
        }

        private void Tampilan()
        {
            BackColor = Color.FromArgb(180, 0, 0, 0);
            panelA.BackColor = Tema.ppc[GlobalVariable.id_tema];
            lblJudul.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
        }

        private void cmbPilihReference_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelA.Visible = false;
            switch (cmbPilihReference.SelectedIndex)
            {
                case 0:
                    OpenChildForm(new FrmTiket());
                    break;
                case 1:
                    OpenChildForm(new FrmGerbong());
                    break;
                case 2:
                    OpenChildForm(new FrmKeteranganTiket());
                    break;
                case 3:
                    OpenChildForm(new FrmPelanggan());
                    break;
                case 4:
                    OpenChildForm(new FrmPesanan());
                    break;
            }
            panelA.Visible = true;
        }

        private void btnSelesai_Click_1(object sender, EventArgs e)
        {
            this.Close();
            OnSelesai();
        }
    }
}
