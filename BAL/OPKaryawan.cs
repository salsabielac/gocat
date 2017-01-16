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
    public class OPKaryawan
    {
        public DBConnection db = new DBConnection();
        public Karyawan kr = new Karyawan();

        public DataTable viewKaryawan(Karyawan kr)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT a.id_karyawan, a.nama, a.alamat, a.telp, b.keterangan, c.keterangan FROM dbo.karyawan a join dbo.agama b on a.id_agama = b.id_agama join dbo.jeniskelamin c on a.id_jk = c.id_jk";
            return db.ExeReader(view);
        }

        public int insertKaryawan(Karyawan kr)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.karyawan VALUES('" + kr.Nama + "', '" + kr.Alamat + "', '" + kr.Telpon + "', '" + kr.Agamas.Id + "', '" + kr.JnsKelamin.Id + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteKaryawan(Karyawan kr)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.karyawan where id_karyawan = ('" + kr.IdKaryawan + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateKaryawan(Karyawan kr)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.karyawan SET nama='" + kr.Nama + "', alamat='" + kr.Alamat + "', telp='" + kr.Telpon + "', id_agama='" + kr.Agamas.Id + "', id_jk='" + kr.JnsKelamin.Id + "' where id_karyawan = '" + kr.IdKaryawan + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
