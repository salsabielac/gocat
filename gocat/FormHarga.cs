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
    public partial class FormHarga : Form
    {
        Harga harga = new Harga();
        OPHarga opHarga = new OPHarga();
 
        public FormHarga()
        {
            InitializeComponent();
            loadDataHarga();
        }

        public void loadDataHarga()
        {
            DataTable dt = new DataTable();
            dt = opHarga.viewHarga(harga);
            dataGridView1.DataSource = dt;
            label5.Text = DateTime.Now.ToShortDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            harga.Keterangan = textBox1.Text;
            harga.Hargaa = Int32.Parse(textBox2.Text);
            harga.Tanggal = Convert.ToDateTime(label5.Text);

            int baris = opHarga.insertHarga(harga);

            if (baris > 0)
            {
                MessageBox.Show("Data Berhasil Disimpan :)");
                loadDataHarga();
            }
            else
            {
                MessageBox.Show("Data Gagal Disimpan :(");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            harga.Id = Int32.Parse(label2.Text);
            harga.Keterangan = textBox1.Text;
            harga.Hargaa = Int32.Parse(textBox2.Text);
            harga.Tanggal = DateTime.Parse(label5.Text);
            opHarga.updateHarga(harga);
            loadDataHarga();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            button1.Enabled = false;
        }

        private void FormHarga_Load(object sender, EventArgs e)
        {

        }
    }
}
