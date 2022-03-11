
namespace KasirTiketKereta.View.Menu.Tambah_Tiket
{
    partial class FrmEntryGerbong
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
            this.panelA = new System.Windows.Forms.Panel();
            this.pgbInput = new System.Windows.Forms.ProgressBar();
            this.txtJumlahKursi = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            this.panelA.SuspendLayout();
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
            this.pnlControl.Size = new System.Drawing.Size(360, 26);
            this.pnlControl.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(335, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelA.Controls.Add(this.pgbInput);
            this.panelA.Controls.Add(this.txtJumlahKursi);
            this.panelA.Controls.Add(this.lblB);
            this.panelA.Controls.Add(this.txtNama);
            this.panelA.Controls.Add(this.lblA);
            this.panelA.Controls.Add(this.btnSimpan);
            this.panelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelA.Location = new System.Drawing.Point(0, 26);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(360, 166);
            this.panelA.TabIndex = 1;
            // 
            // pgbInput
            // 
            this.pgbInput.BackColor = System.Drawing.SystemColors.Window;
            this.pgbInput.Location = new System.Drawing.Point(66, 121);
            this.pgbInput.Maximum = 1000;
            this.pgbInput.Name = "pgbInput";
            this.pgbInput.Size = new System.Drawing.Size(158, 23);
            this.pgbInput.TabIndex = 39;
            // 
            // txtJumlahKursi
            // 
            this.txtJumlahKursi.Location = new System.Drawing.Point(66, 79);
            this.txtJumlahKursi.Name = "txtJumlahKursi";
            this.txtJumlahKursi.Size = new System.Drawing.Size(232, 20);
            this.txtJumlahKursi.TabIndex = 37;
            this.txtJumlahKursi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahKursi_KeyPress);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblB.Location = new System.Drawing.Point(63, 63);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(66, 13);
            this.lblB.TabIndex = 36;
            this.lblB.Text = "Jumlah Kursi";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(66, 38);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(232, 20);
            this.txtNama.TabIndex = 35;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblA.Location = new System.Drawing.Point(63, 22);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(35, 13);
            this.lblA.TabIndex = 34;
            this.lblA.Text = "Nama";
            this.lblA.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Window;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(236, 121);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(62, 23);
            this.btnSimpan.TabIndex = 38;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnPerbaiki_Click);
            // 
            // FrmEntryGerbong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.BackgroundImage = global::KasirTiketKereta.Properties.Resources.DarkPurple;
            this.ClientSize = new System.Drawing.Size(360, 192);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntryGerbong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntryGerbong";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ProgressBar pgbInput;
        private System.Windows.Forms.TextBox txtJumlahKursi;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnSimpan;
    }
}