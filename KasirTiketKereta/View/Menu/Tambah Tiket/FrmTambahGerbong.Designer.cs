
namespace KasirTiketKereta.View.Menu.Tambah_Tiket
{
    partial class FrmTambahGerbong
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
            this.panelA = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTambahController = new System.Windows.Forms.Button();
            this.btnPerbaikiController = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lvwGerbong = new System.Windows.Forms.ListView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panelA.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelA.Controls.Add(this.lblA);
            this.panelA.Controls.Add(this.panel2);
            this.panelA.Location = new System.Drawing.Point(12, 12);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(576, 315);
            this.panelA.TabIndex = 30;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblA.Location = new System.Drawing.Point(4, 3);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(98, 17);
            this.lblA.TabIndex = 27;
            this.lblA.Text = "Data Gerbong";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTambahController);
            this.panel2.Controls.Add(this.btnPerbaikiController);
            this.panel2.Controls.Add(this.btnHapus);
            this.panel2.Controls.Add(this.lvwGerbong);
            this.panel2.Location = new System.Drawing.Point(-2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 301);
            this.panel2.TabIndex = 0;
            // 
            // btnTambahController
            // 
            this.btnTambahController.BackColor = System.Drawing.SystemColors.Window;
            this.btnTambahController.FlatAppearance.BorderSize = 0;
            this.btnTambahController.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahController.Location = new System.Drawing.Point(76, 270);
            this.btnTambahController.Name = "btnTambahController";
            this.btnTambahController.Size = new System.Drawing.Size(62, 23);
            this.btnTambahController.TabIndex = 22;
            this.btnTambahController.Text = "Tambah";
            this.btnTambahController.UseVisualStyleBackColor = false;
            this.btnTambahController.Click += new System.EventHandler(this.btnTambahController_Click_1);
            // 
            // btnPerbaikiController
            // 
            this.btnPerbaikiController.BackColor = System.Drawing.SystemColors.Window;
            this.btnPerbaikiController.FlatAppearance.BorderSize = 0;
            this.btnPerbaikiController.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerbaikiController.Location = new System.Drawing.Point(144, 270);
            this.btnPerbaikiController.Name = "btnPerbaikiController";
            this.btnPerbaikiController.Size = new System.Drawing.Size(62, 23);
            this.btnPerbaikiController.TabIndex = 2;
            this.btnPerbaikiController.Text = "Perbaiki";
            this.btnPerbaikiController.UseVisualStyleBackColor = false;
            this.btnPerbaikiController.Click += new System.EventHandler(this.btnPerbaikiController_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Window;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Location = new System.Drawing.Point(8, 270);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(62, 23);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // lvwGerbong
            // 
            this.lvwGerbong.HideSelection = false;
            this.lvwGerbong.Location = new System.Drawing.Point(8, 17);
            this.lvwGerbong.Name = "lvwGerbong";
            this.lvwGerbong.Size = new System.Drawing.Size(562, 247);
            this.lvwGerbong.TabIndex = 0;
            this.lvwGerbong.UseCompatibleStateImageBehavior = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(513, 337);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "Selesai";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Location = new System.Drawing.Point(423, 337);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 25);
            this.btnPrevious.TabIndex = 32;
            this.btnPrevious.Text = "Sebelumnya";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // FrmTambahGerbong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panelA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTambahGerbong";
            this.Text = "Langkah-2 Tambahkan Data Gerbong";
            this.Load += new System.EventHandler(this.FrmGerbong_Load);
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvwGerbong;
        private System.Windows.Forms.Button btnPerbaikiController;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnTambahController;
        private System.Windows.Forms.Button btnPrevious;
    }
}