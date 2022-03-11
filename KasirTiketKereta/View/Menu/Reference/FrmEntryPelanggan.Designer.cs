
namespace KasirTiketKereta.View.Menu.Reference
{
    partial class FrmEntryPelanggan
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
            this.pnlControl = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAlamatEmail = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtIDPelanggan = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblE = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.txtNamaKasir = new System.Windows.Forms.TextBox();
            this.lblF = new System.Windows.Forms.Label();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlControl.Controls.Add(this.title);
            this.pnlControl.Controls.Add(this.btnClose);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(405, 26);
            this.pnlControl.TabIndex = 1;
            this.pnlControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.ForeColor = System.Drawing.Color.Gainsboro;
            this.title.Location = new System.Drawing.Point(3, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(27, 13);
            this.title.TabIndex = 2;
            this.title.Text = "Title";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(380, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAlamatEmail
            // 
            this.txtAlamatEmail.Location = new System.Drawing.Point(154, 71);
            this.txtAlamatEmail.Name = "txtAlamatEmail";
            this.txtAlamatEmail.Size = new System.Drawing.Size(171, 20);
            this.txtAlamatEmail.TabIndex = 37;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblC.Location = new System.Drawing.Point(68, 74);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(67, 13);
            this.lblC.TabIndex = 36;
            this.lblC.Text = "Alamat Email";
            // 
            // txtIDPelanggan
            // 
            this.txtIDPelanggan.Location = new System.Drawing.Point(154, 19);
            this.txtIDPelanggan.Name = "txtIDPelanggan";
            this.txtIDPelanggan.Size = new System.Drawing.Size(171, 20);
            this.txtIDPelanggan.TabIndex = 35;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblA.Location = new System.Drawing.Point(68, 22);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(72, 13);
            this.lblA.TabIndex = 34;
            this.lblA.Text = "ID Pelanggan";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Window;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(331, 184);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(62, 23);
            this.btnSimpan.TabIndex = 38;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.lblE);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.lblB);
            this.panel1.Controls.Add(this.btnSelesai);
            this.panel1.Controls.Add(this.txtNamaKasir);
            this.panel1.Controls.Add(this.lblF);
            this.panel1.Controls.Add(this.txtNoHP);
            this.panel1.Controls.Add(this.lblD);
            this.panel1.Controls.Add(this.txtAlamatEmail);
            this.panel1.Controls.Add(this.lblC);
            this.panel1.Controls.Add(this.txtIDPelanggan);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 219);
            this.panel1.TabIndex = 2;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cmbGender.Location = new System.Drawing.Point(154, 123);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(171, 21);
            this.cmbGender.TabIndex = 47;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblE.Location = new System.Drawing.Point(68, 126);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(71, 13);
            this.lblE.TabIndex = 46;
            this.lblE.Text = "Jenis Kelamin";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(154, 45);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(171, 20);
            this.txtNama.TabIndex = 45;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblB.Location = new System.Drawing.Point(68, 48);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(35, 13);
            this.lblB.TabIndex = 44;
            this.lblB.Text = "Nama";
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelesai.FlatAppearance.BorderSize = 0;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesai.Location = new System.Drawing.Point(263, 184);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(62, 23);
            this.btnSelesai.TabIndex = 43;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // txtNamaKasir
            // 
            this.txtNamaKasir.Location = new System.Drawing.Point(154, 150);
            this.txtNamaKasir.Name = "txtNamaKasir";
            this.txtNamaKasir.ReadOnly = true;
            this.txtNamaKasir.Size = new System.Drawing.Size(171, 20);
            this.txtNamaKasir.TabIndex = 42;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblF.Location = new System.Drawing.Point(68, 153);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(61, 13);
            this.lblF.TabIndex = 41;
            this.lblF.Text = "Nama Kasir";
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(154, 97);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(171, 20);
            this.txtNoHP.TabIndex = 40;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblD.Location = new System.Drawing.Point(68, 100);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(39, 13);
            this.lblD.TabIndex = 39;
            this.lblD.Text = "No HP";
            // 
            // FrmEntryPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KasirTiketKereta.Properties.Resources.DarkPurple;
            this.ClientSize = new System.Drawing.Size(405, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntryPelanggan";
            this.Text = "Form1";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAlamatEmail;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtIDPelanggan;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNamaKasir;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblB;
    }
}