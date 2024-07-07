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
using System.Diagnostics.Eventing.Reader;

namespace Bromo
{

    public partial class DaftarAkun : Form
    {
        Koneksi get = new Koneksi();
        public DaftarAkun()
        {
            InitializeComponent();
        }
        private void Daftar_Click(object sender, EventArgs e)
        {
            if (UserDaftar.Text.Trim() == "" || PassDaftar.Text.Trim().Length <= 7 || Nama.Text.Trim() == "" || Nomor.Text.Trim().Length <= 10)
            {
                MessageBox.Show("Masukan data kamu dengan benar!!");
            }
            else
            {
                SqlConnection conn = get.GetCon();
                conn.Open();
                string checkDuplicate = "SELECT COUNT * FROM Akun WHERE Username = @Username";
                SqlCommand checkCmd = new SqlCommand(checkDuplicate, conn);
                checkCmd.Parameters.AddWithValue("@Username", UserDaftar.Text);
                int existingUserCount = (int)checkCmd.ExecuteScalar();

                if (existingUserCount > 0)
                {
                    MessageBox.Show("Username sudah terdaftar. Silakan gunakan username lain.");
                }
                else
                {
                    string daftar = "INSERT INTO Akun (Username, Password, Nama, TanggalLahir, NomorTelepon, MerupakanAdmin) VALUES (@Username, @Password, @Nama, @TanggalLahir, @NomorTelepon, 'false')";
                    SqlCommand cmd = new SqlCommand(daftar, conn);
                    cmd.Parameters.AddWithValue("@Username", UserDaftar.Text);
                    cmd.Parameters.AddWithValue("@Password", PassDaftar.Text);
                    cmd.Parameters.AddWithValue("@Nama", Nama.Text);
                    cmd.Parameters.AddWithValue("@TanggalLahir", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@NomorTelepon", Nomor.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                    MessageBox.Show("Sukses");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }
    }
}
