using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Harga
    {
        public Harga()
        {

        }

        public Harga(int Id, string Keterangan)
        {
            this.Id = Id;
            this.Keterangan = Keterangan;
            this.Tanggal = Tanggal;
            this.Hargaa = Hargaa;
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _keterangan;

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

        private DateTime _tanggal;

        public DateTime Tanggal
        {
            get { return _tanggal; }
            set { _tanggal = value; }
        }

        private int _harga;

        public int Hargaa
        {
            get { return _harga; }
            set { _harga = value; }
        }

    }
}
