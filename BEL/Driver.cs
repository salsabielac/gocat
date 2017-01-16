using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Driver
    {
        private int _idDriver;

        public int IdDriver
        {
            get { return _idDriver; }
            set { _idDriver = value; }
        }

        private string _nama;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        private string _alamat;

        public string Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }


        private int _telpon;

        public int Telpon
        {
            get { return _telpon; }
            set { _telpon = value; }
        }

        private Agama _agama;

        public Agama Agamas
        {
            get { return _agama; }
            set { _agama = value; }
        }

        private JenisKelamin _jeniskelamin;

        public JenisKelamin JnsKelamin
        {
            get { return _jeniskelamin; }
            set { _jeniskelamin = value; }
        }


    }
}
