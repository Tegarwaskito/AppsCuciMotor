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
    public partial class Karyawan : Form
    {
        public Karyawan()
        {
            InitializeComponent();
            TampilData();
        }
        private void TampilData()
        {
            string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=db_cuci; Integrated Security=True";
            SqlConnection conn = new SqlConnection(coonstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM karyawan");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = conn;
            sda.SelectCommand = cmd;
            DataTable dtkaryawan = new DataTable();
            sda.Fill(dtkaryawan);
            dgvKaryawan.DataSource = dtkaryawan;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // menambah Karyawan dengan fungsi store procedure
            string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=db_cuci; Integrated Security=True";
            SqlConnection conn = new SqlConnection(coonstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "AKAR";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id_karyawan = new SqlParameter("@id_karyawan", SqlDbType.VarChar);
            SqlParameter nama_karyawan = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter jumlah_cuci = new SqlParameter("@jumlah_cuci", SqlDbType.Int);

            //isian ke text box
            id_karyawan.Value = txtid_karyawan.Text;
            nama_karyawan.Value = txtNama_karyawan.Text;
            jumlah_cuci.Value = txtnumcuci.Text;
            

            //command
            cmd.Parameters.Add(id_karyawan);
            cmd.Parameters.Add(nama_karyawan);
            cmd.Parameters.Add(jumlah_cuci);
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Tersimpan");
                conn.Close();

                TampilData();
                cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = this.dgvKaryawan.CurrentCell.RowIndex;
            var row = this.dgvKaryawan.Rows[index];
            txtid_karyawan.Text = row.Cells[0].Value != null ? Convert.ToString(row.Cells[0].Value) : "";
            txtNama_karyawan.Text = row.Cells[1].Value != null ? Convert.ToString(row.Cells[1].Value) : "";
            txtnumcuci.Text = row.Cells[2].Value != null ? Convert.ToString(row.Cells[2].Value) : "";
            
        }
        private void cleardata()
        {
            txtid_karyawan.Clear();
            txtNama_karyawan.Clear();
            txtnumcuci.Value = 0;
            
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=db_cuci; Integrated Security=True";
            SqlConnection conn = new SqlConnection(coonstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELKAR";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter kode = new SqlParameter("@id_karyawan", SqlDbType.VarChar);
            kode.Value = txtid_karyawan.Text;
            cmd.Parameters.Add(kode);
            if (MessageBox.Show("Apakah Yakin ingin menghapus data ini?", "Hapus Data!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                conn.Close();

                TampilData();
                cleardata();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
