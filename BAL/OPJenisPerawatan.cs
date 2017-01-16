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
    public class OPJenisPerawatan
    {
        public DBConnection db = new DBConnection();
        public JenisPerawatan pr = new JenisPerawatan();

        public DataTable viewJenisPerawatan(JenisPerawatan pr)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT * FROM dbo.jenisperawatan";
            return db.ExeReader(view);
        }

        public int insertJenisPerawatan(JenisPerawatan pr)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.jenisperawatan VALUES('" + pr.Keterangan + "', '" + pr.Hargas.Id + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteJenisPerawatan(JenisPerawatan pr)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.jenisperawatan where id_jperawatan = ('" + pr.Id + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateJenisPerawatan(JenisPerawatan pr)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.jenisperawatan SET keterangan='" + pr.Keterangan + "', id_harga='" + pr.Hargas.Id + "'  where id_jperawatan = '" + pr.Id + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
