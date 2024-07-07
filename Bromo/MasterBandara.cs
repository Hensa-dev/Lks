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
    public partial class MasterBandara : Form
    {
        Koneksi Conn = new Koneksi();
        public MasterBandara()
        {
            InitializeComponent();
        }

        private void MasterBandara_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bromoDataMasterBandara.Bandara' table. You can move, or remove it, as needed.
            this.bandaraTableAdapter.Fill(this.bromoDataMasterBandara.Bandara);

        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Nama.Text.Trim() == "" || KodeAI.Text.Trim() == "" || Kota.Text.Trim() == "" || Alamat.Text.Trim() == "" || Bandara.Text.Trim() == "")
                {
                    MessageBox.Show("Masukan dengan benar!");
                }
                else
                {
                    SqlConnection con = Conn.GetCon();
                    con.Open();
                    string DataMasterBandara = "INSERT INTO Bandara (Nama, KodeIATA, NegaraID, Kota, JumlahTerminal, Alamat)VALUES(@nama, @kodeai, @bandara, @kota, @jumlah, @alamat)";
                    SqlCommand cmd = new SqlCommand(DataMasterBandara, con);
                    cmd.Parameters.AddWithValue("@nama", Nama.Text.Trim());
                    cmd.Parameters.AddWithValue("@kodeai", KodeAI.Text.Trim());
                    cmd.Parameters.AddWithValue("@bandara", Bandara.Text.Trim());
                    cmd.Parameters.AddWithValue("@kota", Kota.Text.Trim());
                    cmd.Parameters.AddWithValue("@jumlah", Convert.ToDecimal(JumlahT.Value));
                    cmd.Parameters.AddWithValue("@alamat", Alamat.Text.Trim());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Berhasil");
                    this.bandaraTableAdapter.Fill(this.bromoDataMasterBandara.Bandara);
                }                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Kesalahan Terjadi!" + ex.Message);
            }
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            Nama.Text = "";
            KodeAI.Text = "";
            Bandara.Text = "";
            JumlahT.Value = 1;
            Alamat.Text = "";

            Nama.Focus();
        }
    }
}
