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
    public class OPJenisKelamin
    {
        public DBConnection db = new DBConnection();
        public JenisKelamin jk = new JenisKelamin();

        public DataTable viewJenisKelamin(JenisKelamin jk)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT * FROM dbo.jeniskelamin";
            return db.ExeReader(view);
        }

        public int insertJenisKelamin(JenisKelamin jk)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.jeniskelamin VALUES('" + jk.Keterangan + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteJenisKelamin(JenisKelamin jk)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.jeniskelamin where id_jk = ('" + jk.Id + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateJenisKelamin(JenisKelamin jk)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.jeniskelamin SET keterangan='" + jk.Keterangan + "' where id_jk = '" + jk.Id + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
