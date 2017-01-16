using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Akun
    {
        public Akun()
        {

        }

        public Akun(int Id, string Nama)
        {
            this.Id = Id;
            this.Nama = Nama;
        }

        private int _idAkun;

        public int IdAkun
        {
            get { return _idAkun; }
            set { _idAkun = value; }
        }

        private string _nama;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        private JenisKelamin _jeniskelamin;

        public JenisKelamin JnsKelamin
        {
            get { return _jeniskelamin; }
            set { _jeniskelamin = value; }
        }

        private Agama _agama;

        public Agama Agamas
        {
            get { return _agama; }
            set { _agama = value; }
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


        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Keterangan { get; private set; }
        public int Id { get; private set; }

        private Kucing _kucing;

        public Kucing Kucings
        {
            get { return _kucing; }
            set { _kucing = value; }
        }

    }
}
