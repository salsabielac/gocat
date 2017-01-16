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
    public class OPKucing
    {
        public DBConnection db = new DBConnection();
        public Kucing ku = new Kucing();

        public DataTable viewKucing(Kucing ku)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT a.id_kucing, a.nama, b.keterangan, c.keterangan, a.usia FROM dbo.kucing a join dbo.jeniskucing b on a.id_jkucing = b.id_jkucing join dbo.jeniskelamin c on a.id_jk = c.id_jk";
            return db.ExeReader(view);
        }

        public int insertKucing(Kucing ku)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.kucing VALUES('" + ku.Nama + "', '" + ku.JnsKucing.Id + "', '" + ku.JnsKelamin.Id + "', '" + ku.Usia + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteKucing(Kucing ku)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.kucing where id_kucing = ('" + ku.IdKucing + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateKucing(Kucing ku)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.kucing SET nama='" + ku.Nama + "', id_jkucing='" + ku.JnsKucing.Id + "', id_jk='" + ku.JnsKelamin.Id + "', usia='" + ku.Usia + "' where id_kucing = '" + ku.IdKucing + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
