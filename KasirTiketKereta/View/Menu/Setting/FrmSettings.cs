using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using KasirTiketKereta.View.Menu.Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu
{
    public partial class FrmSettings : Form
    {
        public delegate void OnUpdateEventHandler(int idx);
        public event OnUpdateEventHandler update;
        public delegate void OnSelesaiEventHandler();
        public event OnSelesaiEventHandler OnSelesai;
        private List<Kasir> listOfKasir;
        private KasirController controller;
        public FrmSettings()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            InisialisasiListView();
            controller = new KasirController();
            LoadDataUser();
            Tampilan();
        }
        public void InisialisasiTema()
        {
            cmbTema.SelectedIndex = GlobalVariable.id_tema;
        }
        private void LoadDataUser()
        {
            lvwUser.Items.Clear();
            listOfKasir = controller.ReadAll();
            foreach (var obj in listOfKasir)
            {
                var noUrut = lvwUser.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.nama_kasir);
                item.SubItems.Add(obj.password);
                lvwUser.Items.Add(item);
            }
        }
        private void InisialisasiListView()
        {
            lvwUser.View = System.Windows.Forms.View.Details;
            lvwUser.FullRowSelect = true;
            lvwUser.GridLines = true;
            lvwUser.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwUser.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            lvwUser.Columns.Add("Password", 135, HorizontalAlignment.Center);
        }
        private void Tampilan()
        {
            BackColor = Color.FromArgb(180, 0, 0, 0);
            panelA.BackColor = Tema.ppc[GlobalVariable.id_tema];
            panelB.BackColor = Tema.ppc[GlobalVariable.id_tema];
            panelC.BackColor = Tema.ppc[GlobalVariable.id_tema];
            lblA.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblB.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblC.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblD.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblE.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblF.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblG.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblH.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblI.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblJ.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblK.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblL.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            panelAdmin.BackColor = Tema.ppc[GlobalVariable.id_tema];
            //untuk mengetahui apakah user yang login atau bukan
            //sehingga hak admin akan dapat muncul sesuai user yang loginnya
            panelAdmin.Visible = string.Equals(Properties.Settings.Default.admin, GlobalVariable.nama, StringComparison.OrdinalIgnoreCase);
        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            //memanggil event
            update(cmbTema.SelectedIndex);
            GlobalVariable.id_tema = cmbTema.SelectedIndex;
            Properties.Settings.Default.idx_tema = cmbTema.SelectedIndex;
            Properties.Settings.Default.Save();
            Tampilan();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
            OnSelesai();
        }
        private void OnCreateEventHandlerKasir(Kasir obj)
        {
            listOfKasir.Add(obj);
            int noUrut = lvwUser.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(obj.nama_kasir);
            item.SubItems.Add(obj.password);
            lvwUser.Items.Add(item);
        }
        private void OnUpdateEventHandlerKasir(Kasir obj)
        {
            int index = lvwUser.SelectedIndices[0];
            ListViewItem itemRow = lvwUser.Items[index];
            itemRow.SubItems[1].Text = obj.nama_kasir;
            itemRow.SubItems[2].Text = obj.password;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryKasir frmEntryKasir = new FrmEntryKasir("Tambah User", controller);
            frmEntryKasir.OnCreate += OnCreateEventHandlerKasir;
            frmEntryKasir.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwUser.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data user ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Kasir kasir = listOfKasir[lvwUser.SelectedIndices[0]];
                    var result = controller.Delete(kasir);
                    if (result > 0) LoadDataUser();
                }
            }
            else
            {
                MessageBox.Show("Data user belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwUser.SelectedItems.Count > 0)
            {
                Kasir kasir = listOfKasir[lvwUser.SelectedIndices[0]];
                FrmEntryKasir frmEntryKasir = new FrmEntryKasir("Edit User", controller, kasir);
                frmEntryKasir.OnUpdate += OnUpdateEventHandlerKasir;
                frmEntryKasir.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data user belum dipilih", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == controller.ReadPassword()) {
                Kasir kasir = new Kasir();
                kasir.nama_kasir = GlobalVariable.nama;
                kasir.password = txtPassword.Text;
                FrmEditProfile frmEditProfile = new FrmEditProfile(controller, kasir);
                frmEditProfile.ShowDialog();
            }
            else
            {
                MessageBox.Show("Password yang anda masukan salah", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
