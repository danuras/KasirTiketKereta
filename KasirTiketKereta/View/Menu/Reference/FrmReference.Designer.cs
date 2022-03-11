
namespace KasirTiketKereta.View.Menu.Reference
{
    partial class FrmReference
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
            this.pnlReference = new System.Windows.Forms.Panel();
            this.cmbPilihReference = new System.Windows.Forms.ComboBox();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.panelA.SuspendLayout();
            this.pnlReference.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelA.Controls.Add(this.pnlReference);
            this.panelA.Controls.Add(this.panel3);
            this.panelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelA.Location = new System.Drawing.Point(0, 0);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(600, 370);
            this.panelA.TabIndex = 32;
            // 
            // pnlReference
            // 
            this.pnlReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.pnlReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReference.Controls.Add(this.cmbPilihReference);
            this.pnlReference.Controls.Add(this.btnSelesai);
            this.pnlReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReference.Location = new System.Drawing.Point(0, 18);
            this.pnlReference.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReference.Name = "pnlReference";
            this.pnlReference.Size = new System.Drawing.Size(596, 348);
            this.pnlReference.TabIndex = 30;
            // 
            // cmbPilihReference
            // 
            this.cmbPilihReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPilihReference.FormattingEnabled = true;
            this.cmbPilihReference.Items.AddRange(new object[] {
            "Tiket",
            "Gerbong",
            "Keterangan Tiket",
            "Pelanggan",
            "Pesanan"});
            this.cmbPilihReference.Location = new System.Drawing.Point(5, 6);
            this.cmbPilihReference.Name = "cmbPilihReference";
            this.cmbPilihReference.Size = new System.Drawing.Size(116, 24);
            this.cmbPilihReference.TabIndex = 26;
            this.cmbPilihReference.TabStop = false;
            this.cmbPilihReference.SelectedIndexChanged += new System.EventHandler(this.cmbPilihReference_SelectedIndexChanged);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelesai.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelesai.FlatAppearance.BorderSize = 0;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesai.Location = new System.Drawing.Point(523, 314);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(62, 23);
            this.btnSelesai.TabIndex = 23;
            this.btnSelesai.TabStop = false;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel3.Controls.Add(this.lblJudul);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 18);
            this.panel3.TabIndex = 28;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblJudul.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblJudul.Location = new System.Drawing.Point(3, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(73, 17);
            this.lblJudul.TabIndex = 27;
            this.lblJudul.Text = "Data Tiket";
            // 
            // FrmReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.panelA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReference";
            this.Text = "Referensi";
            this.panelA.ResumeLayout(false);
            this.pnlReference.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel pnlReference;
        private System.Windows.Forms.ComboBox cmbPilihReference;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblJudul;
    }
}