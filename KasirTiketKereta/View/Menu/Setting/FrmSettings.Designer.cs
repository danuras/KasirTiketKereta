
namespace KasirTiketKereta.View.Menu
{
    partial class FrmSettings
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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.lblG = new System.Windows.Forms.Label();
            this.pnlCA = new System.Windows.Forms.Panel();
            this.btnPerbaiki = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lvwUser = new System.Windows.Forms.ListView();
            this.panelA = new System.Windows.Forms.Panel();
            this.lblH = new System.Windows.Forms.Label();
            this.pnlCB = new System.Windows.Forms.Panel();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.lblI = new System.Windows.Forms.Label();
            this.panelB = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblJ = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.panelC = new System.Windows.Forms.Panel();
            this.lblK = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.lblL = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelAdmin.SuspendLayout();
            this.pnlCA.SuspendLayout();
            this.panelA.SuspendLayout();
            this.pnlCB.SuspendLayout();
            this.panelB.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelC.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAdmin.Controls.Add(this.lblG);
            this.panelAdmin.Controls.Add(this.pnlCA);
            this.panelAdmin.Location = new System.Drawing.Point(303, 122);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(285, 168);
            this.panelAdmin.TabIndex = 24;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblG.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblG.Location = new System.Drawing.Point(5, 2);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(76, 17);
            this.lblG.TabIndex = 15;
            this.lblG.Text = "Hak Admin";
            // 
            // pnlCA
            // 
            this.pnlCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.pnlCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCA.Controls.Add(this.btnPerbaiki);
            this.pnlCA.Controls.Add(this.btnHapus);
            this.pnlCA.Controls.Add(this.btnTambah);
            this.pnlCA.Controls.Add(this.lvwUser);
            this.pnlCA.Location = new System.Drawing.Point(-38, 12);
            this.pnlCA.Name = "pnlCA";
            this.pnlCA.Size = new System.Drawing.Size(321, 153);
            this.pnlCA.TabIndex = 0;
            // 
            // btnPerbaiki
            // 
            this.btnPerbaiki.BackColor = System.Drawing.SystemColors.Window;
            this.btnPerbaiki.FlatAppearance.BorderSize = 0;
            this.btnPerbaiki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerbaiki.Location = new System.Drawing.Point(115, 118);
            this.btnPerbaiki.Name = "btnPerbaiki";
            this.btnPerbaiki.Size = new System.Drawing.Size(61, 22);
            this.btnPerbaiki.TabIndex = 32;
            this.btnPerbaiki.Text = "Perbaiki";
            this.btnPerbaiki.UseVisualStyleBackColor = false;
            this.btnPerbaiki.Click += new System.EventHandler(this.btnPerbaiki_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Window;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Location = new System.Drawing.Point(47, 118);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(62, 22);
            this.btnHapus.TabIndex = 30;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Window;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Location = new System.Drawing.Point(182, 118);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(61, 22);
            this.btnTambah.TabIndex = 31;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lvwUser
            // 
            this.lvwUser.HideSelection = false;
            this.lvwUser.Location = new System.Drawing.Point(45, 9);
            this.lvwUser.Name = "lvwUser";
            this.lvwUser.Size = new System.Drawing.Size(270, 103);
            this.lvwUser.TabIndex = 0;
            this.lvwUser.UseCompatibleStateImageBehavior = false;
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelA.Controls.Add(this.lblH);
            this.panelA.Controls.Add(this.pnlCB);
            this.panelA.Location = new System.Drawing.Point(12, 12);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(256, 82);
            this.panelA.TabIndex = 25;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblH.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblH.Location = new System.Drawing.Point(5, 2);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(44, 17);
            this.lblH.TabIndex = 15;
            this.lblH.Text = "Tema";
            // 
            // pnlCB
            // 
            this.pnlCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.pnlCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCB.Controls.Add(this.cmbTema);
            this.pnlCB.Controls.Add(this.lblI);
            this.pnlCB.Location = new System.Drawing.Point(-38, 12);
            this.pnlCB.Name = "pnlCB";
            this.pnlCB.Size = new System.Drawing.Size(292, 67);
            this.pnlCB.TabIndex = 0;
            // 
            // cmbTema
            // 
            this.cmbTema.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Items.AddRange(new object[] {
            "Dark",
            "Light",
            "Hacker"});
            this.cmbTema.Location = new System.Drawing.Point(45, 35);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(239, 21);
            this.cmbTema.TabIndex = 1;
            this.cmbTema.SelectedIndexChanged += new System.EventHandler(this.cmbTema_SelectedIndexChanged);
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblI.Location = new System.Drawing.Point(42, 17);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(96, 13);
            this.lblI.TabIndex = 0;
            this.lblI.Text = "Pilih tema aplikasi :";
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelB.Controls.Add(this.lblA);
            this.panelB.Controls.Add(this.panel2);
            this.panelB.Location = new System.Drawing.Point(12, 108);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(256, 168);
            this.panelB.TabIndex = 26;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblA.Location = new System.Drawing.Point(5, 2);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(61, 17);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "Tentang";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblJ);
            this.panel2.Controls.Add(this.lblF);
            this.panel2.Controls.Add(this.lblE);
            this.panel2.Controls.Add(this.lblD);
            this.panel2.Controls.Add(this.lblC);
            this.panel2.Controls.Add(this.lblB);
            this.panel2.Location = new System.Drawing.Point(-38, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 153);
            this.panel2.TabIndex = 0;
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblJ.Location = new System.Drawing.Point(42, 116);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(191, 13);
            this.lblJ.TabIndex = 5;
            this.lblJ.Text = "5. Nanda Zaqky Maulana - 20.11.3638";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblF.Location = new System.Drawing.Point(42, 99);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(204, 13);
            this.lblF.TabIndex = 4;
            this.lblF.Text = "4. Darussalaam Nur Rasyidu - 20.11.3637";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblE.Location = new System.Drawing.Point(42, 81);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(157, 13);
            this.lblE.TabIndex = 3;
            this.lblE.Text = "3. Anistya Rosyida - 20.11.3635";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblD.Location = new System.Drawing.Point(42, 61);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(245, 13);
            this.lblD.TabIndex = 2;
            this.lblD.Text = "2. Muhammad Dimas Mugen Dhuhuri - 20.11.3634";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblC.Location = new System.Drawing.Point(42, 43);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(140, 13);
            this.lblC.TabIndex = 1;
            this.lblC.Text = "1. Rian Rusadi - 20.11.3633";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblB.Location = new System.Drawing.Point(42, 17);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(158, 13);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "Aplikasi ini dikembangkan oleh :";
            // 
            // panelC
            // 
            this.panelC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelC.Controls.Add(this.lblK);
            this.panelC.Controls.Add(this.panel4);
            this.panelC.Location = new System.Drawing.Point(303, 12);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(285, 90);
            this.panelC.TabIndex = 26;
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblK.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblK.Location = new System.Drawing.Point(5, 2);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(76, 17);
            this.lblK.TabIndex = 15;
            this.lblK.Text = "Edit Profile";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.lblL);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Location = new System.Drawing.Point(-38, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 75);
            this.panel4.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Window;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(45, 43);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(270, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelesai.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelesai.FlatAppearance.BorderSize = 0;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesai.Location = new System.Drawing.Point(526, 335);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(62, 23);
            this.btnSelesai.TabIndex = 27;
            this.btnSelesai.TabStop = false;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblL.Location = new System.Drawing.Point(44, 13);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(99, 13);
            this.lblL.TabIndex = 2;
            this.lblL.Text = "Masukan password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSettings";
            this.Text = "Pengaturan";
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.pnlCA.ResumeLayout(false);
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            this.pnlCB.ResumeLayout(false);
            this.pnlCB.PerformLayout();
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Panel pnlCA;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Panel pnlCB;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.ListView lvwUser;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnPerbaiki;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.TextBox txtPassword;
    }
}