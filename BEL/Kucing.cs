using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Kucing
    {
        public Kucing()
        {

        }
        private int _idKucing;

        public int IdKucing
        {
            get { return _idKucing; }
            set { _idKucing = value; }
        }

        private string _nama;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        private JenisKucing _jeniskucing;

        public JenisKucing JnsKucing
        {
            get { return _jeniskucing; }
            set { _jeniskucing = value; }
        }

        private JenisKelamin _jeniskelamin;

        public JenisKelamin JnsKelamin
        {
            get { return _jeniskelamin; }
            set { _jeniskelamin = value; }
        }


        private int _usia;
        private string ketKucing;

        public Kucing(int IdKucing, string Nama)
        {
            this.IdKucing = IdKucing;
            this.Nama = Nama;
        }

        public int Usia
        {
            get { return _usia; }
            set { _usia = value; }
        }


    }
}
