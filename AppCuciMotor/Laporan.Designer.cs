
namespace AppCuciMotor
{
    partial class Laporan
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
            this.txtKode2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Kembali = new System.Windows.Forms.Button();
            this.btnCetakSatuan = new System.Windows.Forms.Button();
            this.btn_HapusLap = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKode2
            // 
            this.txtKode2.Location = new System.Drawing.Point(161, 514);
            this.txtKode2.Name = "txtKode2";
            this.txtKode2.ReadOnly = true;
            this.txtKode2.Size = new System.Drawing.Size(113, 22);
            this.txtKode2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id Transaksi";
            // 
            // btn_Kembali
            // 
            this.btn_Kembali.Location = new System.Drawing.Point(813, 559);
            this.btn_Kembali.Name = "btn_Kembali";
            this.btn_Kembali.Size = new System.Drawing.Size(129, 41);
            this.btn_Kembali.TabIndex = 3;
            this.btn_Kembali.Text = "Kembali";
            this.btn_Kembali.UseVisualStyleBackColor = true;
            this.btn_Kembali.Click += new System.EventHandler(this.btn_Kembali_Click);
            // 
            // btnCetakSatuan
            // 
            this.btnCetakSatuan.Location = new System.Drawing.Point(161, 559);
            this.btnCetakSatuan.Name = "btnCetakSatuan";
            this.btnCetakSatuan.Size = new System.Drawing.Size(129, 41);
            this.btnCetakSatuan.TabIndex = 1;
            this.btnCetakSatuan.Text = "Cetak Satu";
            this.btnCetakSatuan.UseVisualStyleBackColor = true;
            this.btnCetakSatuan.Click += new System.EventHandler(this.btnCetakSatuan_Click);
            // 
            // btn_HapusLap
            // 
            this.btn_HapusLap.Location = new System.Drawing.Point(12, 559);
            this.btn_HapusLap.Name = "btn_HapusLap";
            this.btn_HapusLap.Size = new System.Drawing.Size(129, 41);
            this.btn_HapusLap.TabIndex = 2;
            this.btn_HapusLap.Text = "Hapus";
            this.btn_HapusLap.UseVisualStyleBackColor = true;
            this.btn_HapusLap.Click += new System.EventHandler(this.btn_HapusLap_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(813, 113);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(129, 41);
            this.btnCetak.TabIndex = 0;
            this.btnCetak.Text = "Cetak Semua";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "LAPORAN PENJUALAN";
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Location = new System.Drawing.Point(12, 172);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.RowTemplate.Height = 24;
            this.dgvLaporan.Size = new System.Drawing.Size(930, 308);
            this.dgvLaporan.TabIndex = 5;
            this.dgvLaporan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaporan_CellClick);
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(982, 713);
            this.Controls.Add(this.txtKode2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Kembali);
            this.Controls.Add(this.btnCetakSatuan);
            this.Controls.Add(this.btn_HapusLap);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLaporan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Laporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKode2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Kembali;
        private System.Windows.Forms.Button btnCetakSatuan;
        private System.Windows.Forms.Button btn_HapusLap;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvLaporan;
    }
}