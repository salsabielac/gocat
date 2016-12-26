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
    public class OPHarga
    {
        public DBConnection db = new DBConnection();
        public Harga hg = new Harga();

        public DataTable viewHarga(Harga hg)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT * FROM dbo.harga";
            return db.ExeReader(view);
        }

        public int insertHarga(Harga hg)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.harga VALUES('" + hg.Keterangan + "','"+hg.Tanggal+"','"+hg.Hargaa+"')";
            return db.ExeNonQuery(insert);
        }

        public int deleteHarga(Harga hg)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.harga where id_harga = ('" + hg.Id + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateHarga(Harga hg)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.harga SET keterangan='" + hg.Keterangan + "' where id_harga = '" + hg.Id + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
