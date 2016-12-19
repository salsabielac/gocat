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
    public class OPJenisPelayanan
    {
        public DBConnection db = new DBConnection();
        public JenisPelayanan jp = new JenisPelayanan();

        public DataTable viewJenisPelayanan(JenisPelayanan jp)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT * FROM dbo.jenispelayanan";
            return db.ExeReader(view);
        }

        public int insertJenisPelayanan(JenisPelayanan jp)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.jenispelayanan VALUES('" + jp.Keterangan + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteJenisPelayanan(JenisPelayanan jp)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.jenispelayanan where id_jenis = ('" + jp.Id + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateJenisPelayanan(JenisPelayanan jp)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.jenispelayanan SET keterangan='" + jp.Keterangan + "' where id_jenis = '" + jp.Id + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
