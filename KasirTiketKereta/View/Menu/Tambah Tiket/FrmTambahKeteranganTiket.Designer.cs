
namespace KasirTiketKereta.View.Menu.Tambah_Tiket
{
    partial class FrmTambahKeteranganTiket
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.rdoLokal = new System.Windows.Forms.RadioButton();
            this.rdoKota = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.txtTujuan = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.dtpKedatangan = new System.Windows.Forms.DateTimePicker();
            this.panelE = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblK = new System.Windows.Forms.Label();
            this.lblJ = new System.Windows.Forms.Label();
            this.cmbKelas = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblD = new System.Windows.Forms.Label();
            this.panelD = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelA = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtNamaKereta = new System.Windows.Forms.TextBox();
            this.panelB = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtKedatangan = new System.Windows.Forms.TextBox();
            this.lblM = new System.Windows.Forms.Label();
            this.txtBerangkat = new System.Windows.Forms.TextBox();
            this.lblL = new System.Windows.Forms.Label();
            this.panelC = new System.Windows.Forms.Panel();
            this.txtAsal = new System.Windows.Forms.TextBox();
            this.dtpBerangkat = new System.Windows.Forms.DateTimePicker();
            this.panelE.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelD.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelA.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelB.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Window;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(513, 333);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 25);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Berikutnya";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblC.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblC.Location = new System.Drawing.Point(4, 3);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(111, 17);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Jenis Kereta Api";
            // 
            // rdoLokal
            // 
            this.rdoLokal.AutoSize = true;
            this.rdoLokal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoLokal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLokal.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoLokal.Location = new System.Drawing.Point(20, 18);
            this.rdoLokal.Name = "rdoLokal";
            this.rdoLokal.Size = new System.Drawing.Size(51, 17);
            this.rdoLokal.TabIndex = 3;
            this.rdoLokal.TabStop = true;
            this.rdoLokal.Text = "Lokal";
            this.rdoLokal.UseVisualStyleBackColor = false;
            this.rdoLokal.CheckedChanged += new System.EventHandler(this.rdoLokal_CheckedChanged);
            // 
            // rdoKota
            // 
            this.rdoKota.AutoSize = true;
            this.rdoKota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKota.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoKota.Location = new System.Drawing.Point(20, 41);
            this.rdoKota.Name = "rdoKota";
            this.rdoKota.Size = new System.Drawing.Size(75, 17);
            this.rdoKota.TabIndex = 4;
            this.rdoKota.TabStop = true;
            this.rdoKota.Text = "Antar Kota";
            this.rdoKota.UseVisualStyleBackColor = false;
            this.rdoKota.CheckedChanged += new System.EventHandler(this.rdoKota_CheckedChanged);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblA.Location = new System.Drawing.Point(4, 2);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(91, 17);
            this.lblA.TabIndex = 5;
            this.lblA.Text = "Nama Kereta";
            // 
            // txtTujuan
            // 
            this.txtTujuan.Location = new System.Drawing.Point(348, 97);
            this.txtTujuan.Name = "txtTujuan";
            this.txtTujuan.Size = new System.Drawing.Size(232, 20);
            this.txtTujuan.TabIndex = 11;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblE.Location = new System.Drawing.Point(17, 55);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(78, 13);
            this.lblE.TabIndex = 10;
            this.lblE.Text = "Stasiun Tujuan";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblB.Location = new System.Drawing.Point(5, 3);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(164, 17);
            this.lblB.TabIndex = 14;
            this.lblB.Text = "Stasiun Awal dan Tujuan";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblG.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblG.Location = new System.Drawing.Point(5, 2);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(149, 17);
            this.lblG.TabIndex = 15;
            this.lblG.Text = "Harga dan Kelas Tiket";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblF.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblF.Location = new System.Drawing.Point(4, 1);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(236, 17);
            this.lblF.TabIndex = 16;
            this.lblF.Text = "Tanggal Berangkat dan kedatangan";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblH.Location = new System.Drawing.Point(16, 19);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(98, 13);
            this.lblH.TabIndex = 17;
            this.lblH.Text = "Tanggal Berangkat";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblI.Location = new System.Drawing.Point(15, 62);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(107, 13);
            this.lblI.TabIndex = 19;
            this.lblI.Text = "Tanggal Kedatangan";
            // 
            // dtpKedatangan
            // 
            this.dtpKedatangan.Location = new System.Drawing.Point(20, 80);
            this.dtpKedatangan.Name = "dtpKedatangan";
            this.dtpKedatangan.Size = new System.Drawing.Size(132, 20);
            this.dtpKedatangan.TabIndex = 22;
            // 
            // panelE
            // 
            this.panelE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelE.Controls.Add(this.lblG);
            this.panelE.Controls.Add(this.panel2);
            this.panelE.Location = new System.Drawing.Point(339, 153);
            this.panelE.Name = "panelE";
            this.panelE.Size = new System.Drawing.Size(249, 124);
            this.panelE.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtHarga);
            this.panel2.Controls.Add(this.lblK);
            this.panel2.Controls.Add(this.lblJ);
            this.panel2.Controls.Add(this.cmbKelas);
            this.panel2.Location = new System.Drawing.Point(-2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 109);
            this.panel2.TabIndex = 0;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(12, 76);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(228, 20);
            this.txtHarga.TabIndex = 13;
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblK.Location = new System.Drawing.Point(9, 60);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(36, 13);
            this.lblK.TabIndex = 12;
            this.lblK.Text = "Harga";
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblJ.Location = new System.Drawing.Point(9, 20);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(33, 13);
            this.lblJ.TabIndex = 11;
            this.lblJ.Text = "Kelas";
            // 
            // cmbKelas
            // 
            this.cmbKelas.FormattingEnabled = true;
            this.cmbKelas.Items.AddRange(new object[] {
            "Eksekutif",
            "Bisnis",
            "Ekonomi",
            "Premium"});
            this.cmbKelas.Location = new System.Drawing.Point(11, 36);
            this.cmbKelas.Name = "cmbKelas";
            this.cmbKelas.Size = new System.Drawing.Size(229, 21);
            this.cmbKelas.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblD);
            this.panel3.Controls.Add(this.lblE);
            this.panel3.Location = new System.Drawing.Point(-12, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 110);
            this.panel3.TabIndex = 0;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblD.Location = new System.Drawing.Point(17, 13);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(65, 13);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "Stasiun Asal";
            // 
            // panelD
            // 
            this.panelD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelD.Controls.Add(this.lblB);
            this.panelD.Controls.Add(this.panel3);
            this.panelD.Location = new System.Drawing.Point(338, 12);
            this.panelD.Name = "panelD";
            this.panelD.Size = new System.Drawing.Size(249, 126);
            this.panelD.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rdoLokal);
            this.panel5.Controls.Add(this.rdoKota);
            this.panel5.Location = new System.Drawing.Point(-13, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 72);
            this.panel5.TabIndex = 0;
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelA.Controls.Add(this.lblC);
            this.panelA.Controls.Add(this.panel5);
            this.panelA.Location = new System.Drawing.Point(12, 68);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(253, 87);
            this.panelA.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtNamaKereta);
            this.panel7.Location = new System.Drawing.Point(-13, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(263, 35);
            this.panel7.TabIndex = 0;
            // 
            // txtNamaKereta
            // 
            this.txtNamaKereta.Location = new System.Drawing.Point(20, 9);
            this.txtNamaKereta.Name = "txtNamaKereta";
            this.txtNamaKereta.Size = new System.Drawing.Size(232, 20);
            this.txtNamaKereta.TabIndex = 28;
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelB.Controls.Add(this.lblA);
            this.panelB.Controls.Add(this.panel7);
            this.panelB.Location = new System.Drawing.Point(11, 12);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(253, 50);
            this.panelB.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.dtpBerangkat);
            this.panel9.Controls.Add(this.txtKedatangan);
            this.panel9.Controls.Add(this.lblM);
            this.panel9.Controls.Add(this.txtBerangkat);
            this.panel9.Controls.Add(this.lblL);
            this.panel9.Controls.Add(this.dtpKedatangan);
            this.panel9.Controls.Add(this.lblH);
            this.panel9.Controls.Add(this.lblI);
            this.panel9.Location = new System.Drawing.Point(-13, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(279, 119);
            this.panel9.TabIndex = 0;
            // 
            // txtKedatangan
            // 
            this.txtKedatangan.Location = new System.Drawing.Point(161, 80);
            this.txtKedatangan.Name = "txtKedatangan";
            this.txtKedatangan.Size = new System.Drawing.Size(90, 20);
            this.txtKedatangan.TabIndex = 31;
            this.txtKedatangan.Text = "00:00:00";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblM.Location = new System.Drawing.Point(158, 62);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(26, 13);
            this.lblM.TabIndex = 30;
            this.lblM.Text = "Jam";
            // 
            // txtBerangkat
            // 
            this.txtBerangkat.Location = new System.Drawing.Point(161, 39);
            this.txtBerangkat.Name = "txtBerangkat";
            this.txtBerangkat.Size = new System.Drawing.Size(90, 20);
            this.txtBerangkat.TabIndex = 29;
            this.txtBerangkat.Text = "00:00:00";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblL.Location = new System.Drawing.Point(158, 19);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(26, 13);
            this.lblL.TabIndex = 28;
            this.lblL.Text = "Jam";
            // 
            // panelC
            // 
            this.panelC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelC.Controls.Add(this.lblF);
            this.panelC.Controls.Add(this.panel9);
            this.panelC.Location = new System.Drawing.Point(12, 161);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(253, 134);
            this.panelC.TabIndex = 27;
            // 
            // txtAsal
            // 
            this.txtAsal.Location = new System.Drawing.Point(348, 56);
            this.txtAsal.Name = "txtAsal";
            this.txtAsal.Size = new System.Drawing.Size(232, 20);
            this.txtAsal.TabIndex = 9;
            // 
            // dtpBerangkat
            // 
            this.dtpBerangkat.Location = new System.Drawing.Point(20, 39);
            this.dtpBerangkat.Name = "dtpBerangkat";
            this.dtpBerangkat.Size = new System.Drawing.Size(132, 20);
            this.dtpBerangkat.TabIndex = 32;
            // 
            // FrmTambahKeteranganTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.ControlBox = false;
            this.Controls.Add(this.txtTujuan);
            this.Controls.Add(this.txtAsal);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelE);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.panelD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTambahKeteranganTiket";
            this.Text = "Langkah-1 Masukan Informasi Dibawah Ini";
            this.Load += new System.EventHandler(this.FrmKeteranganTiket_Load);
            this.panelE.ResumeLayout(false);
            this.panelE.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelD.ResumeLayout(false);
            this.panelD.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.RadioButton rdoLokal;
        private System.Windows.Forms.RadioButton rdoKota;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtTujuan;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.DateTimePicker dtpKedatangan;
        private System.Windows.Forms.Panel panelE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelD;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.ComboBox cmbKelas;
        private System.Windows.Forms.TextBox txtNamaKereta;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtBerangkat;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.TextBox txtAsal;
        private System.Windows.Forms.TextBox txtKedatangan;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.DateTimePicker dtpBerangkat;
    }
}