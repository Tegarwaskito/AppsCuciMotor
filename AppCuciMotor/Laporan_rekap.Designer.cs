
namespace AppCuciMotor
{
    partial class Laporan_rekap
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
            this.CRVRekap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVRekap
            // 
            this.CRVRekap.ActiveViewIndex = -1;
            this.CRVRekap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVRekap.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVRekap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVRekap.Location = new System.Drawing.Point(0, 0);
            this.CRVRekap.Name = "CRVRekap";
            this.CRVRekap.Size = new System.Drawing.Size(800, 450);
            this.CRVRekap.TabIndex = 0;
            // 
            // Laporan_rekap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRVRekap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Laporan_rekap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cetak Struk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRVRekap;
    }
}