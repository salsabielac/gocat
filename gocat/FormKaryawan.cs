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
    public partial class FormKaryawan : Form
    {
        Karyawan kr = new Karyawan();
        Agama ag = new Agama();
        JenisKelamin jk = new JenisKelamin();
        OPKaryawan opKr = new OPKaryawan();
        OPAgama opAg = new OPAgama();
        OPJenisKelamin opJk = new OPJenisKelamin();

        public FormKaryawan()
        {
            InitializeComponent();
            loadKaryawan();
            loadAgama();
            loadJenisKelamin();
        }

        public void loadKaryawan()
        {
            DataTable dt = new DataTable();
            dt = opKr.viewKaryawan(kr);
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

        private void FormKaryawan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kr.Nama = textBox1.Text;
            kr.Alamat = textBox2.Text;
            kr.Telpon = int.Parse(textBox3.Text);

            int idAgama = (int)comboBox1.SelectedValue;
            String ketAgama = comboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            kr.Agamas = agamaSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            kr.JnsKelamin = jeniskelaminSelected;

            int row = opKr.insertKaryawan(kr);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Berhasil Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadKaryawan();
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
            kr.IdKaryawan = Int32.Parse(label2.Text);
            kr.Nama = textBox1.Text;
            kr.Alamat = textBox2.Text;
            kr.Telpon = int.Parse(textBox3.Text);

            int idAgama = (int)comboBox1.SelectedValue;
            string ketAgama = comboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            kr.Agamas = agamaSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            kr.JnsKelamin = jeniskelaminSelected;

            int row = opKr.updateKaryawan(kr);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Berhasil Diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadKaryawan();
            }
            else
            {
                MessageBox.Show(this, "Data Gagal Diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kr.IdKaryawan = Int32.Parse(label2.Text);
            kr.Nama = textBox1.Text;
            kr.Alamat = textBox2.Text;
            kr.Telpon = int.Parse(textBox3.Text);

            int idAgama = (int)comboBox1.SelectedValue;
            string ketAgama = comboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            kr.Agamas = agamaSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            kr.JnsKelamin = jeniskelaminSelected;

            int row = opKr.deleteKaryawan(kr);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Telah Dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadKaryawan();
            }
            else
            {
                MessageBox.Show(this, "Data Telah Dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
