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
    public class OPJenisKucing
    {
        public DBConnection db = new DBConnection();
        public JenisKucing jc = new JenisKucing();

        public DataTable viewJenisKucing(JenisKucing jc)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT * FROM dbo.jeniskucing";
            return db.ExeReader(view);
        }

        public int insertJenisKucing(JenisKucing jc)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.jeniskucing VALUES('" + jc.Keterangan + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteJenisKucing(JenisKucing jc)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.jeniskucing where id_jkucing = ('" + jc.Id + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateJenisKucing(JenisKucing jc)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.jeniskucing SET keterangan='" + jc.Keterangan + "' where id_jkucing = '" + jc.Id + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
