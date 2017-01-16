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
    public partial class FormDokter : Form
    {
        Dokter dk = new Dokter();
        Agama ag = new Agama();
        JenisKelamin jk = new JenisKelamin();
        OPDokter opDk = new OPDokter();
        OPAgama opAg = new OPAgama();
        OPJenisKelamin opJk = new OPJenisKelamin();

        public FormDokter()
        {
            InitializeComponent();
            loadDokter();
            loadAgama();
            loadJenisKelamin();
        }

        public void loadDokter()
        {
            DataTable dt = new DataTable();
            dt = opDk.viewDokter(dk);
            dataGridView1.DataSource = dt;
        }

        public void loadAgama()
        {
            DataTable dt = new DataTable();
            dt = opAg.viewAgama(ag);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "id_agama";
            comboBox1.DisplayMember = "keterangan";
        }

        public void loadJenisKelamin()
        {
            DataTable dt = new DataTable();
            dt = opJk.viewJenisKelamin(jk);
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "id_jk";
            comboBox2.DisplayMember = "keterangan";
        }

        private void FormDokter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dk.Nama = textBox1.Text;
            dk.Alamat = textBox2.Text;
            dk.Telpon = int.Parse(textBox3.Text);

            int idAgama = (int)comboBox1.SelectedValue;
            String ketAgama = comboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            dk.Agamas = agamaSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            dk.JnsKelamin = jeniskelaminSelected;

            int row = opDk.insertDokter(dk);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Berhasil Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadDokter();
            }
            else
            {
                MessageBox.Show(this, "Data Gagal Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dk.IdDokter = Int32.Parse(label2.Text);
            dk.Nama = textBox1.Text;
            dk.Alamat = textBox2.Text;
            dk.Telpon = int.Parse(textBox3.Text);

            int idAgama = (int)comboBox1.SelectedValue;
            string ketAgama = comboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            dk.Agamas = agamaSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            dk.JnsKelamin = jeniskelaminSelected;

            int row = opDk.updateDokter(dk);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Berhasil Diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadDokter();
            }
            else
            {
                MessageBox.Show(this, "Data Gagal Diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dk.IdDokter = Int32.Parse(label2.Text);
            dk.Nama = textBox1.Text;
            dk.Alamat = textBox2.Text;
            dk.Telpon = int.Parse(textBox3.Text);

            int idAgama = (int)comboBox1.SelectedValue;
            string ketAgama = comboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            dk.Agamas = agamaSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            dk.JnsKelamin = jeniskelaminSelected;

            int row = opDk.deleteDokter(dk);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Telah Dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadDokter();
            }
            else
            {
                MessageBox.Show(this, "Data Telah Dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
