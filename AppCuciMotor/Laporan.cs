using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppCuciMotor
{
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
            TampilLaporan();
        }
        private void TampilLaporan()
        {
            string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=db_cuci; Integrated Security=True";
            SqlConnection conn = new SqlConnection(coonstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM pembayaran");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = conn;
            sda.SelectCommand = cmd;
            DataTable dtBarang = new DataTable();
            sda.Fill(dtBarang);
            dgvLaporan.DataSource = dtBarang;
        }

        private void dgvLaporan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = this.dgvLaporan.CurrentCell.RowIndex;
            var row = this.dgvLaporan.Rows[index];
            txtKode2.Text = row.Cells[0].Value != null ? Convert.ToString(row.Cells[0].Value) : "";
        }

        private void btnCetakSatuan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cetak Struk satuan ?", "Cetak Nota!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Laporan_rekap lr = new Laporan_rekap();
                lr.Show();
                string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=db_cuci; Integrated Security=True";
                SqlConnection conn = new SqlConnection(coonstring);
                SqlCommand cmd = new SqlCommand("SELECT * FROM pembayaran where id_transaksi='" + txtKode2.Text + "'");
                SqlDataAdapter sda = new SqlDataAdapter();
                cmd.Connection = conn;
                sda.SelectCommand = cmd;
                DataTable dtTransaksi = new DataTable();
                sda.Fill(dtTransaksi);

                //objek crystal report
                CR_Transaksi rekap_trans = new CR_Transaksi();
                rekap_trans.SetDataSource(dtTransaksi);

                lr.CRVRekap.ReportSource = rekap_trans;
                lr.CRVRekap.Refresh();
            }
        }

        private void btn_HapusLap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Yakin ingin menghapus data ini?", "Hapus Data!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=db_cuci; Integrated Security=True";
                SqlConnection conn = new SqlConnection(coonstring);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELTRANS";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id_transaksi = new SqlParameter("@id_transaksi", SqlDbType.VarChar);
                id_transaksi.Value = txtKode2.Text;
                cmd.Parameters.Add(id_transaksi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil");
                conn.Close();
                TampilLaporan();
                txtKode2.Clear();
            }
        }

        private void btn_Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            Laporan_rekap lr = new Laporan_rekap();
            lr.Show();
            string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=db_cuci; Integrated Security=True";
            SqlConnection conn = new SqlConnection(coonstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM pembayaran");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = conn;
            sda.SelectCommand = cmd;
            DataTable dtTransaksi = new DataTable();
            sda.Fill(dtTransaksi);

            //objek crystal report
            CR_Transaksi rekap_trans = new CR_Transaksi();
            rekap_trans.SetDataSource(dtTransaksi);

            lr.CRVRekap.ReportSource = rekap_trans;
            lr.CRVRekap.Refresh();
        }
    }
}
