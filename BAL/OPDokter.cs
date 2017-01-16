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
    public class OPDokter
    {
        public DBConnection db = new DBConnection();
        public Dokter dk = new Dokter();

        public DataTable viewDokter(Dokter dk)
        {
            SqlCommand view = new SqlCommand();
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT a.id_dokter, a.nama, a.alamat, a.telp, b.keterangan, c.keterangan FROM dbo.dokter a join dbo.agama b on a.id_agama = b.id_agama join dbo.jeniskelamin c on a.id_jk = c.id_jk";
            return db.ExeReader(view);
        }

        public int insertDokter(Dokter dk)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.dokter VALUES('" + dk.Nama + "', '" + dk.Agamas.Id + "', '" + dk.JnsKelamin.Id + "', '" + dk.Alamat + "', '" + dk.Telpon + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteDokter(Dokter dk)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.dokter where id_dokter = ('" + dk.IdDokter + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateDokter(Dokter dk)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE driver SET nama='" + dk.Nama + "', id_agama='" + dk.Agamas.Id + "', id_jk='" + dk.JnsKelamin.Id + "', alamat='" + dk.Alamat + "', telp='" + dk.Telpon + "' where id_dokter = '" + dk.IdDokter + "'";
            return db.ExeNonQuery(upd);
        }
    }
}
