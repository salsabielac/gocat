using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Agama
    {
        public Agama()
        {

        }

        public Agama(int Id, string Keterangan)
        {
            this.Id = Id;
            this.Keterangan = Keterangan;
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

    }
}
