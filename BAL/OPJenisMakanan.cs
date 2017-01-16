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
    public class OPJenisMakanan
    {
        public DBConnection db = new DBConnection();
        public JenisMakanan mk = new JenisMakanan();

        public DataTable viewJenisMakanan(JenisMakanan mk)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT * FROM dbo.jenismakanan";
            return db.ExeReader(view);
        }

        public int insertJenisMakanan(JenisMakanan mk)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.jenismakanan VALUES('" + mk.Keterangan + "', '" + mk.Hargas.Id + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteJenisMakanan(JenisMakanan mk)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.jenismakanan where id_jmakanan = ('" + mk.Id + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateJenisMakanan(JenisMakanan mk)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.jenismakanan SET keterangan='" + mk.Keterangan + "', id_harga='" + mk.Hargas.Id + "'  where id_jmakanan = '" + mk.Id + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
