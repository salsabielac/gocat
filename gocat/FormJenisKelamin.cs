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
    public partial class FormJenisKelamin : Form
    {
        JenisKelamin jeniskelamin = new JenisKelamin();
        OPJenisKelamin opJenisKelamin = new OPJenisKelamin();

        public FormJenisKelamin()
        {
            InitializeComponent();
            loadDataJenisKelamin();
        }

        public void loadDataJenisKelamin()
        {
            DataTable dt = new DataTable();
            dt = opJenisKelamin.viewJenisKelamin(jeniskelamin);
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FormJenisKelamin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jeniskelamin.Id = Int32.Parse(label2.Text);
            jeniskelamin.Keterangan = textBox1.Text;
            opJenisKelamin.updateJenisKelamin(jeniskelamin);
            loadDataJenisKelamin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jeniskelamin.Id = Int32.Parse(label2.Text);
            opJenisKelamin.deleteJenisKelamin(jeniskelamin);
            loadDataJenisKelamin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jeniskelamin.Keterangan = textBox1.Text;

            int baris = opJenisKelamin.insertJenisKelamin(jeniskelamin);

            if (baris > 0)
            {
                MessageBox.Show("Data Berhasil Disimpan :)");
                loadDataJenisKelamin();
            }
            else
            {
                MessageBox.Show("Data Gagal Disimpan :(");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            button1.Enabled = false;
        }
    }
}
