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
    public partial class FormJenisPelayanan : Form
    {
        JenisPelayanan jenispelayanan = new JenisPelayanan();
        OPJenisPelayanan opJenisPelayanan = new OPJenisPelayanan();

        public FormJenisPelayanan()
        {
            InitializeComponent();
            loadDataJenisPelayanan();
        }

        public void loadDataJenisPelayanan()
        {
            DataTable dt = new DataTable();
            dt = opJenisPelayanan.viewJenisPelayanan(jenispelayanan);
            dataGridView1.DataSource = dt;
        }
        private void FormJenisPelayanan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jenispelayanan.Keterangan = textBox1.Text;

            int baris = opJenisPelayanan.insertJenisPelayanan(jenispelayanan);

            if (baris > 0)
            {
                MessageBox.Show("Data Berhasil Disimpan :)");
                loadDataJenisPelayanan();
            }
            else
            {
                MessageBox.Show("Data Gagal Disimpan :(");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jenispelayanan.Id = Int32.Parse(label2.Text);
            opJenisPelayanan.deleteJenisPelayanan(jenispelayanan);
            loadDataJenisPelayanan();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jenispelayanan.Id = Int32.Parse(label2.Text);
            jenispelayanan.Keterangan = textBox1.Text;
            opJenisPelayanan.updateJenisPelayanan(jenispelayanan);
            loadDataJenisPelayanan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            button1.Enabled = false;
        }
    }
}
