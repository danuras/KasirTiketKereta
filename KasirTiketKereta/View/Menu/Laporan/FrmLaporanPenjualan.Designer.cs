
namespace KasirTiketKereta.View.Menu.Reference
{
    partial class FrmLaporanPenjualan
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
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lvwReferences = new System.Windows.Forms.ListView();
            this.btnCari = new System.Windows.Forms.Button();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtTiket = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSemua = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCari
            // 
            this.txtCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCari.Location = new System.Drawing.Point(250, 3);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(194, 24);
            this.txtCari.TabIndex = 30;
            // 
            // lvwReferences
            // 
            this.lvwReferences.BackColor = System.Drawing.SystemColors.Window;
            this.lvwReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwReferences.HideSelection = false;
            this.lvwReferences.Location = new System.Drawing.Point(3, 41);
            this.lvwReferences.Name = "lvwReferences";
            this.lvwReferences.Size = new System.Drawing.Size(570, 254);
            this.lvwReferences.TabIndex = 26;
            this.lvwReferences.UseCompatibleStateImageBehavior = false;
            // 
            // btnCari
            // 
            this.btnCari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCari.BackColor = System.Drawing.SystemColors.Window;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Location = new System.Drawing.Point(450, 4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(56, 23);
            this.btnCari.TabIndex = 32;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cmbField
            // 
            this.cmbField.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Items.AddRange(new object[] {
            "Kelas",
            "Stasiun Asal",
            "Stasiun Tujuan",
            "Jumlah",
            "Tersedia",
            "Tidak Terjual",
            "Terjual",
            "Pendapatan"});
            this.cmbField.Location = new System.Drawing.Point(123, 3);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(121, 24);
            this.cmbField.TabIndex = 33;
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotal.Location = new System.Drawing.Point(74, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(103, 23);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.Text = "0";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblA.Location = new System.Drawing.Point(3, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 28);
            this.lblA.TabIndex = 35;
            this.lblA.Text = "Total Pendapatan";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblB.Location = new System.Drawing.Point(183, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(121, 28);
            this.lblB.TabIndex = 37;
            this.lblB.Text = "Jumlah/Tersedia/Tidak Terjual/Terjual";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTiket
            // 
            this.txtTiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTiket.Location = new System.Drawing.Point(310, 3);
            this.txtTiket.Name = "txtTiket";
            this.txtTiket.ReadOnly = true;
            this.txtTiket.Size = new System.Drawing.Size(124, 23);
            this.txtTiket.TabIndex = 36;
            this.txtTiket.Text = "0/0/0/0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lvwReferences, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 332);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.Controls.Add(this.btnCari, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCari, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbField, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSemua, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(570, 32);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // btnSemua
            // 
            this.btnSemua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSemua.BackColor = System.Drawing.SystemColors.Window;
            this.btnSemua.FlatAppearance.BorderSize = 0;
            this.btnSemua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemua.ForeColor = System.Drawing.Color.Black;
            this.btnSemua.Location = new System.Drawing.Point(512, 4);
            this.btnSemua.Name = "btnSemua";
            this.btnSemua.Size = new System.Drawing.Size(55, 23);
            this.btnSemua.TabIndex = 34;
            this.btnSemua.Text = "Semua";
            this.btnSemua.UseVisualStyleBackColor = false;
            this.btnSemua.Click += new System.EventHandler(this.btnSemua_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblA, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTiket, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTotal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblB, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 301);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(570, 28);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // FrmLaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(576, 332);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLaporanPenjualan";
            this.Text = "Laporan Penjualan";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ListView lvwReferences;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtTiket;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSemua;
    }
}