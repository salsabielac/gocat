using BEL;
using DataAccessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class OPJenisKesehatan
    {
        public DBConnection db = new DBConnection();
        public JenisKesehatan jh = new JenisKesehatan();

        public DataTable viewJenisKesehatan(JenisKesehatan jh)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT * FROM dbo.jeniskesehatan";
            return db.ExeReader(view);
        }

        public int insertJenisKesehatan(JenisKesehatan jh)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.jeniskesehatan VALUES('" + jh.Keterangan + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteJenisKelamin(JenisKesehatan jh)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.jeniskesehatan where id_jhealth = ('" + jh.Id + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateJenisKelamin(JenisKesehatan jh)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.jeniskesehatan SET keterangan='" + jh.Keterangan + "' where id_jhealth = '" + jh.Id + "'";
            return db.ExeNonQuery(upd);
        }

    }
}
