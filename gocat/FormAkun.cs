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
    public partial class FormAkun : Form
    {
        Akun ak = new Akun();
        Agama ag = new Agama();
        JenisKelamin jk = new JenisKelamin();
        Kucing ku = new Kucing();
        OPAkun opAk = new OPAkun();
        OPAgama opAg = new OPAgama();
        OPJenisKelamin opJk = new OPJenisKelamin();
        OPKucing opKu = new OPKucing();

        public FormAkun()
        {
            InitializeComponent();
            loadAkun();
            loadAgama();
            loadJenisKelamin();
            loadKucing();
        }

        public void loadAkun()
        {
            DataTable dt = new DataTable();
            dt = opAk.viewAkun(ak);
            dataGridView1.DataSource = dt;
           
        }

        public void loadAgama()
        {
            DataTable dt = new DataTable();
            dt = opAg.viewAgama(ag);
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "id_agama";
            comboBox2.DisplayMember = "keterangan";
        }

        public void loadJenisKelamin()
        {
            DataTable dt = new DataTable();
            dt = opJk.viewJenisKelamin(jk);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "id_jk";
            comboBox1.DisplayMember = "keterangan";
        }

        public void loadKucing()
        {
            DataTable dt = new DataTable();
            dt = opKu.viewKucing(ku);
            comboBox3.DataSource = dt;
            comboBox3.ValueMember = "id_kucing";
            comboBox3.DisplayMember = "nama";

        }

        private void FormAkun_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ak.Nama = textBox1.Text;
            ak.Alamat = textBox2.Text;
            ak.Telpon = int.Parse(textBox3.Text);
            ak.Email = textBox5.Text;
            ak.Username = textBox4.Text;
            ak.Password = textBox6.Text;

            int idAgama = (int)comboBox1.SelectedValue;
            String ketAgama = comboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            ak.Agamas = agamaSelected;
              
            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            ak.JnsKelamin = jeniskelaminSelected;

            int idKucing = (int)comboBox3.SelectedValue;
            String ketKucing = comboBox3.DisplayMember;
            Kucing kucingSelected = new Kucing(idKucing, ketKucing);
            ak.Kucings = kucingSelected;

            int row = opAk.insertAkun(ak);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Berhasil Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadAkun();
            }
            else
            {
                MessageBox.Show(this, "Data Gagal Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ak.IdAkun = Int32.Parse(label2.Text);
            ak.Nama = textBox1.Text;
            ak.Alamat = textBox2.Text;
            ak.Telpon = int.Parse(textBox3.Text);
            ak.Email = textBox5.Text;
            ak.Username = textBox4.Text;
            ak.Password = textBox6.Text;

            int idAgama = (int)comboBox1.SelectedValue;
            string ketAgama = comboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            ak.Agamas = agamaSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            ak.JnsKelamin = jeniskelaminSelected;

            int idKucing = (int)comboBox3.SelectedValue;
            String ketKucing = comboBox3.DisplayMember;
            Kucing kucingSelected = new Kucing(idKucing, ketKucing);
            ak.Kucings = kucingSelected;

            int row = opAk.updateAkun(ak);
            if (row >= 0)
            {
                MessageBox.Show(this, "Data Berhasil Diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadAkun();
            }
            else
            {
                MessageBox.Show(this, "Data Gagal Diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ak.IdAkun = int.Parse(label2.Text);
            ak.Nama = textBox1.Text;
            ak.Alamat = textBox2.Text;
            ak.Telpon = int.Parse(textBox3.Text);
            ak.Email = textBox5.Text;
            ak.Username = textBox4.Text;
            ak.Password = textBox6.Text;

            int idAgama = (int)comboBox1.SelectedValue;
            string ketAgama = comboBox1.DisplayMember;
            Agama agamaSelected = new Agama(idAgama, ketAgama);
            ak.Agamas = agamaSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            ak.JnsKelamin = jeniskelaminSelected;

            int idKucing = (int)comboBox3.SelectedValue;
            String ketKucing = comboBox3.DisplayMember;
            Kucing kucingSelected = new Kucing(idKucing, ketKucing);
            ak.Kucings = kucingSelected;

            int row = opAk.deleteAkun(ak);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Telah Dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadAkun();
            }
            else
            {
                MessageBox.Show(this, "Data Telah Dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            button1.Enabled = false;
        }
    }
}
