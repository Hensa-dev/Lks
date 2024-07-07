using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bromo
{
    internal class Koneksi
    {
        public SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-7K50QVN\\HENSA;Initial Catalog=BromoAirlines;Integrated Security=True;";
            return con;
        }
    }
}
