using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCuciMotor
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Pembayaran_Click(object sender, EventArgs e)
        {
            Pembayaran pmb = new Pembayaran();
            pmb.ShowDialog();
        }

        private void Paket_Click(object sender, EventArgs e)
        {
            Paket lap = new Paket();
            lap.ShowDialog();
        }

        private void Karyawan_Click(object sender, EventArgs e)
        {
            Karyawan lap = new Karyawan();
            lap.ShowDialog();
        }

        private void Laporan_Click(object sender, EventArgs e)
        {
            Laporan lap = new Laporan();
            lap.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            var Login = new Login();
            Login.Show();
        }
    }
}
