using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    public class DBConnection
    {
        public SqlConnection koneksi = new SqlConnection("Data Source=DOUBLE-PC;Initial Catalog=cat;Integrated Security=True");

        public SqlConnection getCon()
        {
            if(koneksi.State == ConnectionState.Closed)
            {
                koneksi.Open();
            }
            return koneksi;
        }

        public DataTable ExeReader(SqlCommand cm)
        {

            cm.Connection = getCon();
            SqlDataReader ldr;
            DataTable dt = new DataTable();

            ldr = cm.ExecuteReader();
            dt.Load(ldr);
            koneksi.Close();
            return dt;

        }

        public int ExeNonQuery(SqlCommand cm)
        {
            cm.Connection = getCon();
            int rowsaffected = -1;
            rowsaffected = cm.ExecuteNonQuery();
            koneksi.Close();
            return rowsaffected;
        }

        public object ExeScalar(SqlCommand cm)
        {
            cm.Connection = getCon();
            object ob = -1;
            ob = cm.ExecuteScalar();
            koneksi.Close();
            return ob;
        }

    }
}
