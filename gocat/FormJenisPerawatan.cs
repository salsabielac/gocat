using BAL;
using BEL;
using System;
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
    public partial class FormJenisPerawatan : Form
    {
        JenisPerawatan jp = new JenisPerawatan();
        Harga hg = new Harga();
        OPJenisPerawatan opJp = new OPJenisPerawatan();
        OPHarga opHg = new OPHarga();

        public FormJenisPerawatan()
        {
            InitializeComponent();
            loadJenisPerawatan();
            loadHarga();
        }

        public void loadJenisPerawatan()
        {
            DataTable dt = new DataTable();
            dt = opJp.viewJenisPerawatan(jp);
            dataGridView1.DataSource = dt;
        }

        public void loadHarga()
        {
            DataTable dt = new DataTable();
            dt = opHg.viewHarga(hg);
            dataGridView1.DataSource = dt;
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "id_harga";
            comboBox1.DisplayMember = "keterangan";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormJenisPerawatan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jp.Keterangan = textBox1.Text;

            int idHarga = (int)comboBox1.SelectedValue;
            String ketHarga = comboBox1.DisplayMember;
            Harga hargaSelected = new Harga(idHarga, ketHarga);
            jp.Hargas = hargaSelected;
            
            int row = opJp.insertJenisPerawatan(jp);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Berhasil Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadJenisPerawatan();
            }
            else
            {
                MessageBox.Show(this, "Data Gagal Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
