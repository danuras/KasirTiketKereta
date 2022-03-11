
namespace KasirTiketKereta
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlTitle2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnPengaturan = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnTambahTiket = new System.Windows.Forms.Button();
            this.btnReferences = new System.Windows.Forms.Button();
            this.btnPesan = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.pnlTitle2.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnPengaturan);
            this.panelMenu.Controls.Add(this.btnLaporan);
            this.panelMenu.Controls.Add(this.btnTambahTiket);
            this.panelMenu.Controls.Add(this.btnReferences);
            this.panelMenu.Controls.Add(this.btnPesan);
            this.panelMenu.Controls.Add(this.pnlTitle2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // pnlTitle2
            // 
            this.pnlTitle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(80)))), ((int)(((byte)(14)))));
            this.pnlTitle2.Controls.Add(this.label1);
            this.pnlTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle2.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle2.Name = "pnlTitle2";
            this.pnlTitle2.Size = new System.Drawing.Size(200, 80);
            this.pnlTitle2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasir Tiket Kereta Api";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.pnlTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(600, 80);
            this.panelTitleBar.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(575, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Black;
            this.pnlTitle.ColumnCount = 1;
            this.pnlTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTitle.Controls.Add(this.lblTitle, 0, 0);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.RowCount = 1;
            this.pnlTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTitle.Size = new System.Drawing.Size(600, 80);
            this.pnlTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(594, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBackground.BackgroundImage = global::KasirTiketKereta.Properties.Resources.Hacker;
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(200, 80);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(600, 370);
            this.panelBackground.TabIndex = 3;
            this.panelBackground.SizeChanged += new System.EventHandler(this.panelDesktopPanel_SizeChanged);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.Image = global::KasirTiketKereta.Properties.Resources.minimize_sign_white;
            this.btnMinimize.Location = new System.Drawing.Point(525, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Black;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnMaximize.Image = global::KasirTiketKereta.Properties.Resources.minimize_white;
            this.btnMaximize.Location = new System.Drawing.Point(550, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnPengaturan
            // 
            this.btnPengaturan.BackColor = System.Drawing.Color.Black;
            this.btnPengaturan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPengaturan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPengaturan.FlatAppearance.BorderSize = 0;
            this.btnPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengaturan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengaturan.ForeColor = System.Drawing.Color.Silver;
            this.btnPengaturan.Image = global::KasirTiketKereta.Properties.Resources.settings_white;
            this.btnPengaturan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengaturan.Location = new System.Drawing.Point(0, 320);
            this.btnPengaturan.Margin = new System.Windows.Forms.Padding(0);
            this.btnPengaturan.Name = "btnPengaturan";
            this.btnPengaturan.Size = new System.Drawing.Size(200, 60);
            this.btnPengaturan.TabIndex = 2;
            this.btnPengaturan.Text = "    Pengaturan";
            this.btnPengaturan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengaturan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPengaturan.UseVisualStyleBackColor = false;
            this.btnPengaturan.Click += new System.EventHandler(this.btnPengaturan_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.Black;
            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.Silver;
            this.btnLaporan.Image = global::KasirTiketKereta.Properties.Resources.laporan_white;
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(0, 260);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(0);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(200, 60);
            this.btnLaporan.TabIndex = 6;
            this.btnLaporan.Text = "    Laporan";
            this.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnTambahTiket
            // 
            this.btnTambahTiket.BackColor = System.Drawing.Color.Black;
            this.btnTambahTiket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTambahTiket.FlatAppearance.BorderSize = 0;
            this.btnTambahTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahTiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahTiket.ForeColor = System.Drawing.Color.Silver;
            this.btnTambahTiket.Image = global::KasirTiketKereta.Properties.Resources.tiket_white;
            this.btnTambahTiket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambahTiket.Location = new System.Drawing.Point(0, 200);
            this.btnTambahTiket.Margin = new System.Windows.Forms.Padding(0);
            this.btnTambahTiket.Name = "btnTambahTiket";
            this.btnTambahTiket.Size = new System.Drawing.Size(200, 60);
            this.btnTambahTiket.TabIndex = 4;
            this.btnTambahTiket.Text = "    Tambah Tiket";
            this.btnTambahTiket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambahTiket.UseVisualStyleBackColor = false;
            this.btnTambahTiket.Click += new System.EventHandler(this.btnTambahTiket_Click);
            // 
            // btnReferences
            // 
            this.btnReferences.BackColor = System.Drawing.Color.Black;
            this.btnReferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReferences.FlatAppearance.BorderSize = 0;
            this.btnReferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferences.ForeColor = System.Drawing.Color.Silver;
            this.btnReferences.Image = ((System.Drawing.Image)(resources.GetObject("btnReferences.Image")));
            this.btnReferences.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReferences.Location = new System.Drawing.Point(0, 140);
            this.btnReferences.Margin = new System.Windows.Forms.Padding(0);
            this.btnReferences.Name = "btnReferences";
            this.btnReferences.Size = new System.Drawing.Size(200, 60);
            this.btnReferences.TabIndex = 3;
            this.btnReferences.Text = "    Referensi";
            this.btnReferences.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReferences.UseVisualStyleBackColor = false;
            this.btnReferences.Click += new System.EventHandler(this.btnReferences_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.BackColor = System.Drawing.Color.Black;
            this.btnPesan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesan.FlatAppearance.BorderSize = 0;
            this.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.ForeColor = System.Drawing.Color.Silver;
            this.btnPesan.Image = global::KasirTiketKereta.Properties.Resources.payment_white;
            this.btnPesan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesan.Location = new System.Drawing.Point(0, 80);
            this.btnPesan.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(200, 60);
            this.btnPesan.TabIndex = 1;
            this.btnPesan.Text = "    Pesan Tiket";
            this.btnPesan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesan.UseVisualStyleBackColor = false;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.MenuForm_SizeChanged);
            this.panelMenu.ResumeLayout(false);
            this.pnlTitle2.ResumeLayout(false);
            this.pnlTitle2.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel pnlTitle2;
        private System.Windows.Forms.Button btnTambahTiket;
        private System.Windows.Forms.Button btnReferences;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.TableLayoutPanel pnlTitle;
        private System.Windows.Forms.Button btnPengaturan;
    }
}