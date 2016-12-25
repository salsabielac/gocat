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
    public partial class FormJenisKesehatan : Form
    {
        JenisKesehatan jeniskesehatan = new JenisKesehatan();
        OPJenisKesehatan opJenisKesehatan = new OPJenisKesehatan();

        public FormJenisKesehatan()
        {
            InitializeComponent();
            loadDataJenisKesehatan();
        }

        public void loadDataJenisKesehatan()
        {
            DataTable dt = new DataTable();
            dt = opJenisKesehatan.viewJenisKesehatan(jeniskesehatan);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jeniskesehatan.Keterangan = textBox1.Text;

            int baris = opJenisKesehatan.insertJenisKesehatan(jeniskesehatan);

            if (baris > 0)
            {
                MessageBox.Show("Data Berhasil Disimpan :)");
                loadDataJenisKesehatan();
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jeniskesehatan.Id = Int32.Parse(label2.Text);
            jeniskesehatan.Keterangan = textBox1.Text;
            opJenisKesehatan.updateJenisKesehatan(jeniskesehatan);
            loadDataJenisKesehatan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jeniskesehatan.Id = Int32.Parse(label2.Text);
            opJenisKesehatan.deleteJenisKesehatan(jeniskesehatan);
            loadDataJenisKesehatan();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
