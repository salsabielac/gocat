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
    public class OPDriver
    {
        public DBConnection db = new DBConnection();
        public Driver dr = new Driver();

        public DataTable viewDriver(Driver dr)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT a.id_driver, a.nama, a.alamat, a.telp, b.keterangan, c.keterangan FROM dbo.driver a join dbo.agama b on a.id_agama = b.id_agama join dbo.jeniskelamin c on a.id_jk = c.id_jk";
            return db.ExeReader(view);
        }

        public int insertDriver(Driver dr)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.driver VALUES('" + dr.Nama + "', '" + dr.Alamat + "', '" + dr.Telpon + "', '" + dr.Agamas.Id + "', '" + dr.JnsKelamin.Id + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteDriver(Driver dr)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.driver where id_driver = ('" + dr.IdDriver + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateDriver(Driver dr)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.driver SET nama='" + dr.Nama + "', alamat='" + dr.Alamat + "', telp='" + dr.Telpon + "', id_agama='" + dr.Agamas.Id + "', id_jk='" + dr.JnsKelamin.Id + "' where id_driver = '" + dr.IdDriver + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
