using BEL; //Iki Tekan Import Library BEL
using DataAccessLogic; //Iki Tekan Import Library DAL
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; //Iki Tekan Class e SQLClient
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class OPAgama
    {

        public DBConnection db = new DBConnection(); //Tekan CTRL + . , Ben Iso Import
        public Agama agg = new Agama(); //Podo Koyo Instansiasi DBConnection

        //Jeneng Method e seterah
        public DataTable viewAgama(Agama agama) //Data Table Iku Import disek + kudu duwe return
        {
            SqlCommand view = new SqlCommand(); //Iki kudu import pisan
            view.CommandType = CommandType.Text;
            view.CommandText = "SELECT * FROM dbo.agama";
            return db.ExeReader(view); //Iki nilai balik e method viewAgama
        }

        public int insertAgama(Agama a) //Iki kudu duwe return pisan
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO dbo.agama VALUES('" + a.Keterangan + "')";
            return db.ExeNonQuery(insert);
        }

        public int deleteAgama(Agama cabe)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM dbo.agama where id_agama = ('" + cabe.Id + "')";
            return db.ExeNonQuery(delete);
        }

        public int updateAgama(Agama aa)
        {
            SqlCommand upd = new SqlCommand();
            upd.CommandType = CommandType.Text;
            upd.CommandText = "UPDATE dbo.agama SET keterangan='" + aa.Keterangan + "' where id_agama = '" + aa.Id + "'";
            return db.ExeNonQuery(upd);
        }

        public DataTable viewId(Agama aga)
        {
            SqlCommand a = new SqlCommand();
            a.CommandType = CommandType.Text;
            a.CommandText = "Select * from agama order by id ASC";
            return db.ExeReader(a);
        }

    }
}
