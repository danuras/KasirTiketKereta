
namespace KasirTiketKereta.View.Menu.Reference
{
    partial class FrmPesanan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnPerbaiki = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lvwReferences = new System.Windows.Forms.ListView();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSemua = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.SystemColors.Window;
            this.btnCari.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Location = new System.Drawing.Point(458, 3);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(50, 23);
            this.btnCari.TabIndex = 31;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCari.Location = new System.Drawing.Point(250, 3);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(202, 24);
            this.txtCari.TabIndex = 30;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Window;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Location = new System.Drawing.Point(72, 3);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(61, 22);
            this.btnTambah.TabIndex = 29;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnPerbaiki
            // 
            this.btnPerbaiki.BackColor = System.Drawing.SystemColors.Window;
            this.btnPerbaiki.FlatAppearance.BorderSize = 0;
            this.btnPerbaiki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerbaiki.Location = new System.Drawing.Point(139, 3);
            this.btnPerbaiki.Name = "btnPerbaiki";
            this.btnPerbaiki.Size = new System.Drawing.Size(60, 22);
            this.btnPerbaiki.TabIndex = 28;
            this.btnPerbaiki.Text = "Perbaiki";
            this.btnPerbaiki.UseVisualStyleBackColor = false;
            this.btnPerbaiki.Click += new System.EventHandler(this.btnPerbaiki_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Window;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Location = new System.Drawing.Point(3, 3);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(62, 22);
            this.btnHapus.TabIndex = 27;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // lvwReferences
            // 
            this.lvwReferences.BackColor = System.Drawing.SystemColors.Window;
            this.lvwReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwReferences.HideSelection = false;
            this.lvwReferences.Location = new System.Drawing.Point(3, 41);
            this.lvwReferences.Name = "lvwReferences";
            this.lvwReferences.Size = new System.Drawing.Size(570, 254);
            this.lvwReferences.TabIndex = 26;
            this.lvwReferences.UseCompatibleStateImageBehavior = false;
            // 
            // cmbField
            // 
            this.cmbField.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Items.AddRange(new object[] {
            "ID Pesanan",
            "Waktu Pesan",
            "Metode Pembayaran",
            "Jumlah Tiket",
            "Total Bayar",
            "ID Pelanggan",
            "Nama Kasir"});
            this.cmbField.Location = new System.Drawing.Point(122, 3);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(122, 24);
            this.cmbField.TabIndex = 34;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lvwReferences, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 332);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Controls.Add(this.btnCari, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbField, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCari, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSemua, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(570, 32);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // btnSemua
            // 
            this.btnSemua.BackColor = System.Drawing.SystemColors.Window;
            this.btnSemua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSemua.FlatAppearance.BorderSize = 0;
            this.btnSemua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemua.ForeColor = System.Drawing.Color.Black;
            this.btnSemua.Location = new System.Drawing.Point(514, 3);
            this.btnSemua.Name = "btnSemua";
            this.btnSemua.Size = new System.Drawing.Size(53, 23);
            this.btnSemua.TabIndex = 35;
            this.btnSemua.Text = "Semua";
            this.btnSemua.UseVisualStyleBackColor = false;
            this.btnSemua.Click += new System.EventHandler(this.btnSemua_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnHapus, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnTambah, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPerbaiki, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 301);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(570, 28);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // FrmPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(576, 332);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesanan";
            this.Text = "Data Pesanan";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnPerbaiki;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.ListView lvwReferences;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSemua;
    }
}