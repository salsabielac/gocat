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
    public partial class FormJenisKucing : Form
    {
        JenisKucing jeniskucing = new JenisKucing();
        OPJenisKucing opJenisKucing = new OPJenisKucing();

        public FormJenisKucing()
        {
            InitializeComponent();
            loadDataJenisKucing();
        }

        public void loadDataJenisKucing()
        {
            DataTable dt = new DataTable();
            dt = opJenisKucing.viewJenisKucing(jeniskucing);
            dataGridView1.DataSource = dt;
        }

        private void FormJenisKucing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jeniskucing.Keterangan = textBox1.Text;

            int baris = opJenisKucing.insertJenisKucing(jeniskucing);

            if (baris > 0)
            {
                MessageBox.Show("Data Berhasil Disimpan :)");
                loadDataJenisKucing();
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

        private void button3_Click(object sender, EventArgs e)
        {
            jeniskucing.Id = Int32.Parse(label2.Text);
            opJenisKucing.deleteJenisKucing(jeniskucing);
            loadDataJenisKucing();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jeniskucing.Id = Int32.Parse(label2.Text);
            jeniskucing.Keterangan = textBox1.Text;
            opJenisKucing.updateJenisKucing(jeniskucing);
            loadDataJenisKucing();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }
    }
}
