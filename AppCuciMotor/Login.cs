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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string koneksi = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=db_cuci; Integrated Security=True";
            SqlConnection con = new SqlConnection(koneksi);

            if (txtUsername.Text == "" | txtPassword.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");

            }

            con.Open();
            var cmd = new SqlCommand("SELECT * FROM login WHERE username=@username AND password=@password", con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                MessageBox.Show("Berhasil Masuk !");
                Home homer = new Home();
                homer.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User id atau password tidak valid", "Peringatan");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
