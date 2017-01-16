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
    public class OPAkun
    {
        public DBConnection db = new DBConnection();
        public Akun ak = new Akun();

        public DataTable viewAkun(Akun ak)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT a.id_pelanggan, a.nama, c.keterangan as 'Jenis Kelamin ', b.keterangan, a.alamat, a.telp, a.email, a.username, a.password, d.nama FROM dbo.akun a join dbo.agama b on a.id_agama = b.id_agama join dbo.jeniskelamin c on a.id_jk = c.id_jk join dbo.kucing d on a.id_kucing = d.id_kucing";
            return db.ExeReader(view);
        }

        public int insertAkun(Akun ak)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.akun VALUES('" + ak.Nama + "', '" + ak.JnsKelamin.Id + "', '" + ak.Agamas.Id + "', '" + ak.Alamat + "', '" + ak.Telpon + "', '" + ak.Email + "', '" + ak.Username + "', '" + ak.Password + "', '" + ak.Kucings.IdKucing + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteAkun(Akun ak)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.akun where id_pelanggan = '" + ak.IdAkun + "' ";
            return db.ExeNonQuery(delete);
        }

        public int updateAkun(Akun ak)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.akun SET nama='" + ak.Nama + "', id_jk='" + ak.JnsKelamin.Id + "', id_agama='" + ak.Agamas.Id + "', alamat='" + ak.Alamat + "', telp='" + ak.Telpon + "', email='" + ak.Email + "', username='" + ak.Username + "', password='" + ak.Password + "', id_kucing='" + ak.Kucings.IdKucing + "' where id_pelanggan = '" + ak.IdAkun + "' ";
            return db.ExeNonQuery(upd);
        }
    }
}
