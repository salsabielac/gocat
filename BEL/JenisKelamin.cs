﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class JenisKelamin
    {

        public JenisKelamin() { }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _keterangan;
        private int idJenisKelamin;
        private string ketJenisKelamin;

        public JenisKelamin(int Id, string Keterangan)
        {
            this.Id = Id;
            this.Keterangan = Keterangan;
        }

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

    }
}
