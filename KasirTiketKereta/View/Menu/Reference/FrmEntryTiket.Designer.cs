
namespace KasirTiketKereta.View.Menu.Reference
{
    partial class FrmEntryTiket
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
            this.txtNomorKursi = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtIDTiket = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.txtIDGerbong = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.txtIDPesan = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
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
            // txtNomorKursi
            // 
            this.txtNomorKursi.Location = new System.Drawing.Point(149, 64);
            this.txtNomorKursi.Name = "txtNomorKursi";
            this.txtNomorKursi.Size = new System.Drawing.Size(171, 20);
            this.txtNomorKursi.TabIndex = 37;
            this.txtNomorKursi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomorKursi_KeyPress);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblB.Location = new System.Drawing.Point(63, 67);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(64, 13);
            this.lblB.TabIndex = 36;
            this.lblB.Text = "Nomor Kursi";
            // 
            // txtIDTiket
            // 
            this.txtIDTiket.Location = new System.Drawing.Point(149, 39);
            this.txtIDTiket.Name = "txtIDTiket";
            this.txtIDTiket.Size = new System.Drawing.Size(171, 20);
            this.txtIDTiket.TabIndex = 35;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblA.Location = new System.Drawing.Point(63, 42);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(45, 13);
            this.lblA.TabIndex = 34;
            this.lblA.Text = "ID Tiket";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Window;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(258, 153);
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
            this.panel1.Controls.Add(this.btnSelesai);
            this.panel1.Controls.Add(this.txtIDGerbong);
            this.panel1.Controls.Add(this.lblD);
            this.panel1.Controls.Add(this.txtIDPesan);
            this.panel1.Controls.Add(this.lblC);
            this.panel1.Controls.Add(this.txtNomorKursi);
            this.panel1.Controls.Add(this.lblB);
            this.panel1.Controls.Add(this.txtIDTiket);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 219);
            this.panel1.TabIndex = 2;
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelesai.FlatAppearance.BorderSize = 0;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesai.Location = new System.Drawing.Point(190, 153);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(62, 23);
            this.btnSelesai.TabIndex = 43;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // txtIDGerbong
            // 
            this.txtIDGerbong.Location = new System.Drawing.Point(149, 116);
            this.txtIDGerbong.Name = "txtIDGerbong";
            this.txtIDGerbong.Size = new System.Drawing.Size(171, 20);
            this.txtIDGerbong.TabIndex = 42;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblD.Location = new System.Drawing.Point(63, 119);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(62, 13);
            this.lblD.TabIndex = 41;
            this.lblD.Text = "ID Gerbong";
            // 
            // txtIDPesan
            // 
            this.txtIDPesan.Location = new System.Drawing.Point(149, 90);
            this.txtIDPesan.Name = "txtIDPesan";
            this.txtIDPesan.Size = new System.Drawing.Size(171, 20);
            this.txtIDPesan.TabIndex = 40;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblC.Location = new System.Drawing.Point(63, 93);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(63, 13);
            this.lblC.TabIndex = 39;
            this.lblC.Text = "ID Pesanan";
            // 
            // FrmEntryTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KasirTiketKereta.Properties.Resources.DarkPurple;
            this.ClientSize = new System.Drawing.Size(405, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntryTiket";
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
        private System.Windows.Forms.TextBox txtNomorKursi;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtIDTiket;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIDGerbong;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtIDPesan;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnSelesai;
    }
}