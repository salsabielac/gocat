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
    public partial class FormKucing : Form
    {
        Kucing ku = new Kucing();
        JenisKucing jc = new JenisKucing();
        JenisKelamin jk = new JenisKelamin();
        OPKucing opKu = new OPKucing();
        OPJenisKucing opJc = new OPJenisKucing();
        OPJenisKelamin opJk = new OPJenisKelamin();

        public FormKucing()
        {
            InitializeComponent();
            loadKucing();
            loadJenisKucing();
            loadJenisKelamin();
        }
        
        public void loadKucing()
        {
            DataTable dt = new DataTable();
            dt = opKu.viewKucing(ku);
            dataGridView1.DataSource = dt;
        }

        public void loadJenisKucing()
        {
            DataTable dt = new DataTable();
            dt = opJc.viewJenisKucing(jc);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "id_jkucing";
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

        private void FormKucing_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ku.Nama = textBox1.Text;
            ku.Usia = int.Parse(textBox2.Text);

            int idJKucing = (int)comboBox1.SelectedValue;
            String ketJnsKucing = comboBox1.DisplayMember;
            JenisKucing jkucingSelected = new JenisKucing(idJKucing, ketJnsKucing);
            ku.JnsKucing = jkucingSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            ku.JnsKelamin = jeniskelaminSelected;

            int row = opKu.insertKucing(ku);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Berhasil Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadKucing();
            }
            else
            {
                MessageBox.Show(this, "Data Gagal Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ku.IdKucing = Int32.Parse(label2.Text);
            ku.Nama = textBox1.Text;
            ku.Usia = int.Parse(textBox2.Text);

            int idJKucing = (int)comboBox1.SelectedValue;
            String ketJnsKucing = comboBox1.DisplayMember;
            JenisKucing jkucingSelected = new JenisKucing(idJKucing, ketJnsKucing);
            ku.JnsKucing = jkucingSelected;

            int idJenisKelamin = (int)comboBox2.SelectedValue;
            String ketJenisKelamin = comboBox2.DisplayMember;
            JenisKelamin jeniskelaminSelected = new JenisKelamin(idJenisKelamin, ketJenisKelamin);
            ku.JnsKelamin = jeniskelaminSelected;

            int row = opKu.updateKucing(ku);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Berhasil Diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadKucing();
            }
            else
            {
                MessageBox.Show(this, "Data Gagal Diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ku.IdKucing = Int32.Parse(label2.Text);
            
            int row = opKu.deleteKucing(ku);
            if (row > 0)
            {
                MessageBox.Show(this, "Data Berhasil Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadKucing();
            }
            else
            {
                MessageBox.Show(this, "Data Gagal Ditambahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
