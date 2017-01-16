﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gocat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void agamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgama fa = new FormAgama();
            fa.ShowDialog();
        }

        private void jenisKucingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJenisKucing fku = new FormJenisKucing();
            fku.ShowDialog();
        }

        private void jenisKelaminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJenisKelamin fkl = new FormJenisKelamin();
            fkl.ShowDialog();
        }

        private void jenisKesehatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJenisKesehatan fks = new FormJenisKesehatan();
            fks.ShowDialog();
        }

        private void jenisPelayananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJenisPelayanan fpl = new FormJenisPelayanan();
            fpl.ShowDialog();
        }

        private void hargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHarga fhg = new FormHarga();
            fhg.ShowDialog();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDriver fdr = new FormDriver();
            fdr.ShowDialog();
        }

        private void dokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDokter fdo = new FormDokter();
            fdo.ShowDialog();
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKaryawan fkr = new FormKaryawan();
            fkr.ShowDialog();
        }

        private void jenisPerawatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJenisPerawatan fjp = new FormJenisPerawatan();
            fjp.ShowDialog();
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAkun fak = new FormAkun();
            fak.ShowDialog();
        }

        private void kucingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKucing fku = new FormKucing();
            fku.ShowDialog();
        }
    }
}
