
namespace KasirTiketKereta.View.Menu.Pesan_Tiket
{
    partial class FrmPesan
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
            this.btnSelesai = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbKelas = new System.Windows.Forms.ComboBox();
            this.lblE = new System.Windows.Forms.Label();
            this.btnCek = new System.Windows.Forms.Button();
            this.txtSisa = new System.Windows.Forms.TextBox();
            this.txtAsal = new System.Windows.Forms.TextBox();
            this.txtTujuan = new System.Windows.Forms.TextBox();
            this.lblF = new System.Windows.Forms.Label();
            this.panelA = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPesan = new System.Windows.Forms.Button();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblJ = new System.Windows.Forms.Label();
            this.cmbPembayaran = new System.Windows.Forms.ComboBox();
            this.lblB = new System.Windows.Forms.Label();
            this.panelB = new System.Windows.Forms.Panel();
            this.lblG = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pgbPesan = new System.Windows.Forms.ProgressBar();
            this.panelC = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panelA.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelesai.FlatAppearance.BorderSize = 0;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesai.ForeColor = System.Drawing.Color.Black;
            this.btnSelesai.Location = new System.Drawing.Point(513, 333);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 25);
            this.btnSelesai.TabIndex = 0;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblC.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblC.Location = new System.Drawing.Point(21, 15);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(65, 13);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Stasiun Asal";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblD.Location = new System.Drawing.Point(21, 41);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(78, 13);
            this.lblD.TabIndex = 4;
            this.lblD.Text = "Stasiun Tujuan";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblA.Location = new System.Drawing.Point(7, 5);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(99, 17);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "Pesanan Tiket";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbKelas);
            this.panel4.Controls.Add(this.lblE);
            this.panel4.Controls.Add(this.btnCek);
            this.panel4.Controls.Add(this.txtSisa);
            this.panel4.Controls.Add(this.lblC);
            this.panel4.Controls.Add(this.txtAsal);
            this.panel4.Controls.Add(this.lblD);
            this.panel4.Controls.Add(this.txtTujuan);
            this.panel4.Controls.Add(this.lblF);
            this.panel4.Location = new System.Drawing.Point(-15, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 182);
            this.panel4.TabIndex = 12;
            // 
            // cmbKelas
            // 
            this.cmbKelas.FormattingEnabled = true;
            this.cmbKelas.Items.AddRange(new object[] {
            "Eksekutif",
            "Bisnis",
            "Ekonomi",
            "Premium"});
            this.cmbKelas.Location = new System.Drawing.Point(112, 64);
            this.cmbKelas.Name = "cmbKelas";
            this.cmbKelas.Size = new System.Drawing.Size(135, 21);
            this.cmbKelas.TabIndex = 37;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblE.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblE.Location = new System.Drawing.Point(21, 67);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(33, 13);
            this.lblE.TabIndex = 35;
            this.lblE.Text = "Kelas";
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.SystemColors.Window;
            this.btnCek.FlatAppearance.BorderSize = 0;
            this.btnCek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCek.ForeColor = System.Drawing.Color.Black;
            this.btnCek.Location = new System.Drawing.Point(210, 97);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(37, 25);
            this.btnCek.TabIndex = 34;
            this.btnCek.Text = "OK";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtSisa
            // 
            this.txtSisa.Location = new System.Drawing.Point(112, 133);
            this.txtSisa.Name = "txtSisa";
            this.txtSisa.ReadOnly = true;
            this.txtSisa.Size = new System.Drawing.Size(136, 20);
            this.txtSisa.TabIndex = 7;
            // 
            // txtAsal
            // 
            this.txtAsal.Location = new System.Drawing.Point(112, 11);
            this.txtAsal.Name = "txtAsal";
            this.txtAsal.Size = new System.Drawing.Size(136, 20);
            this.txtAsal.TabIndex = 3;
            // 
            // txtTujuan
            // 
            this.txtTujuan.Location = new System.Drawing.Point(112, 38);
            this.txtTujuan.Name = "txtTujuan";
            this.txtTujuan.Size = new System.Drawing.Size(136, 20);
            this.txtTujuan.TabIndex = 5;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblF.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblF.Location = new System.Drawing.Point(21, 136);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(54, 13);
            this.lblF.TabIndex = 6;
            this.lblF.Text = "Sisa Tiket";
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelA.Controls.Add(this.lblA);
            this.panelA.Controls.Add(this.panel4);
            this.panelA.Location = new System.Drawing.Point(12, 12);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(248, 185);
            this.panelA.TabIndex = 14;
            this.panelA.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtTotal);
            this.panel7.Controls.Add(this.btnPesan);
            this.panel7.Controls.Add(this.txtJumlah);
            this.panel7.Controls.Add(this.lblH);
            this.panel7.Controls.Add(this.lblI);
            this.panel7.Controls.Add(this.lblJ);
            this.panel7.Controls.Add(this.cmbPembayaran);
            this.panel7.Location = new System.Drawing.Point(-19, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 157);
            this.panel7.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(116, 44);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(136, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // btnPesan
            // 
            this.btnPesan.BackColor = System.Drawing.SystemColors.Window;
            this.btnPesan.FlatAppearance.BorderSize = 0;
            this.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesan.ForeColor = System.Drawing.Color.Black;
            this.btnPesan.Location = new System.Drawing.Point(177, 122);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(75, 25);
            this.btnPesan.TabIndex = 35;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = false;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(115, 15);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(136, 20);
            this.txtJumlah.TabIndex = 13;
            this.txtJumlah.TextChanged += new System.EventHandler(this.txtJumlah_TextChanged);
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlah_KeyPress);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblH.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblH.Location = new System.Drawing.Point(24, 18);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(67, 13);
            this.lblH.TabIndex = 12;
            this.lblH.Text = "Jumlah Tiket";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblI.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblI.Location = new System.Drawing.Point(25, 47);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(63, 13);
            this.lblI.TabIndex = 10;
            this.lblI.Text = "Total Harga";
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblJ.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblJ.Location = new System.Drawing.Point(24, 79);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(105, 13);
            this.lblJ.TabIndex = 10;
            this.lblJ.Text = "Metode Pembayaran";
            // 
            // cmbPembayaran
            // 
            this.cmbPembayaran.FormattingEnabled = true;
            this.cmbPembayaran.Items.AddRange(new object[] {
            "Cash",
            "Kartu Dedit",
            "Kartu Kredit",
            "E-Wallet"});
            this.cmbPembayaran.Location = new System.Drawing.Point(27, 95);
            this.cmbPembayaran.Name = "cmbPembayaran";
            this.cmbPembayaran.Size = new System.Drawing.Size(225, 21);
            this.cmbPembayaran.TabIndex = 11;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblB.Location = new System.Drawing.Point(5, 2);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(64, 17);
            this.lblB.TabIndex = 30;
            this.lblB.Text = "Pesanan";
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelB.Controls.Add(this.lblB);
            this.panelB.Controls.Add(this.panel7);
            this.panelB.Location = new System.Drawing.Point(339, 12);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(249, 171);
            this.panelB.TabIndex = 33;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblG.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblG.Location = new System.Drawing.Point(5, 2);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(52, 17);
            this.lblG.TabIndex = 30;
            this.lblG.Text = "Proses";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pgbPesan);
            this.panel1.Location = new System.Drawing.Point(-19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 52);
            this.panel1.TabIndex = 0;
            // 
            // pgbPesan
            // 
            this.pgbPesan.Location = new System.Drawing.Point(26, 14);
            this.pgbPesan.Maximum = 1000;
            this.pgbPesan.Name = "pgbPesan";
            this.pgbPesan.Size = new System.Drawing.Size(225, 23);
            this.pgbPesan.TabIndex = 0;
            // 
            // panelC
            // 
            this.panelC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelC.Controls.Add(this.lblG);
            this.panelC.Controls.Add(this.panel1);
            this.panelC.Location = new System.Drawing.Point(12, 203);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(249, 66);
            this.panelC.TabIndex = 34;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Location = new System.Drawing.Point(432, 333);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 25);
            this.btnPrevious.TabIndex = 34;
            this.btnPrevious.Text = "Sebelumnya";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // FrmPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.btnSelesai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesan";
            this.Text = "Langkah-2 Masukkan Tiket Yang Dipesan";
            this.Load += new System.EventHandler(this.FrmPesan_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAsal;
        private System.Windows.Forms.TextBox txtTujuan;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.ComboBox cmbPembayaran;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.ComboBox cmbKelas;
        private System.Windows.Forms.TextBox txtSisa;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pgbPesan;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Button btnPrevious;
    }
}