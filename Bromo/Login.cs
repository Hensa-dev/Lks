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

namespace Bromo
{
    public partial class Login : Form
    {
        private SqlCommand cmd;
        //private SqlDataReader rr;
        //private DataSet ds;
        //private SqlDataAdapter ar;
        
        Koneksi get = new Koneksi();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            PassBox.PasswordChar = '*';
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection con = get.GetCon();
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Akun WHERE Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", UsernameBox.Text);
                cmd.Parameters.AddWithValue("@password", PassBox.Text);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader["MerupakanAdmin"].ToString();
                    if(role == "True")
                    {
                        Menu mu = new Menu();
                        mu.Show();
                    }
                    else
                    {
                        FormUser FU = new FormUser();
                        FU.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Salah!!, Tolong masukan dengan benar data login Anda");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DaftarAkun daftar = new DaftarAkun();
            daftar.Show();
            this.Hide();
        }

    }
}
