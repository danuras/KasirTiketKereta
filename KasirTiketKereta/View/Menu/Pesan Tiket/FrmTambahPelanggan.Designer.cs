
using System.Drawing;

namespace KasirTiketKereta.View.Menu.Pesan_Tiket
{
    partial class FrmTambahPelanggan
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
            this.panelB = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelB.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelB.Controls.Add(this.lblA);
            this.panelB.Controls.Add(this.panel2);
            this.panelB.Location = new System.Drawing.Point(179, 54);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(235, 215);
            this.panelB.TabIndex = 14;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblA.Location = new System.Drawing.Point(7, 5);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(133, 17);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "Identitas Pelanggan";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtNoHp);
            this.panel2.Controls.Add(this.lblB);
            this.panel2.Controls.Add(this.cmbJenisKelamin);
            this.panel2.Controls.Add(this.txtNama);
            this.panel2.Controls.Add(this.lblE);
            this.panel2.Controls.Add(this.lblC);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.lblD);
            this.panel2.Location = new System.Drawing.Point(-15, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 212);
            this.panel2.TabIndex = 12;
            // 
            // txtNoHp
            // 
            this.txtNoHp.Location = new System.Drawing.Point(24, 119);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(215, 20);
            this.txtNoHp.TabIndex = 7;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblB.Location = new System.Drawing.Point(21, 15);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(35, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Nama";
            // 
            // cmbJenisKelamin
            // 
            this.cmbJenisKelamin.FormattingEnabled = true;
            this.cmbJenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cmbJenisKelamin.Location = new System.Drawing.Point(24, 164);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(215, 21);
            this.cmbJenisKelamin.TabIndex = 9;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(24, 31);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(215, 20);
            this.txtNama.TabIndex = 3;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblE.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblE.Location = new System.Drawing.Point(21, 148);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(71, 13);
            this.lblE.TabIndex = 8;
            this.lblE.Text = "Jenis Kelamin";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblC.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblC.Location = new System.Drawing.Point(21, 58);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(67, 13);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "Alamat Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblD.Location = new System.Drawing.Point(21, 103);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(105, 13);
            this.lblD.TabIndex = 6;
            this.lblD.Text = "No HandPhone Aktif";
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
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Berikutnya";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FrmTambahPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTambahPelanggan";
            this.Text = "Langkah-1 Masukkan Data Pelanggan";
            this.Load += new System.EventHandler(this.FrmPelanggan_Load);
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Button btnNext;
    }
}