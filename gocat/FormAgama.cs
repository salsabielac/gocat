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
    public partial class FormAgama : Form
    {
        Agama agama = new Agama();
        OPAgama opAgama = new OPAgama();

        public FormAgama() //Iki Mlaku pas proses Instansiasi
        {
            InitializeComponent();//Iki gawanan :D
            loadDataAgama(); //Nampilne method sing nok isor kui
        }

        public void loadDataAgama()//Iki method e gawe dewe , digae load data agama
        {
            DataTable dt = new DataTable();
            dt = opAgama.viewAgama(agama);// Nyeluk Method Agama , parametere objek agama
            dataGridView1.DataSource = dt; //Ngelbokne datane nang gridview
        }

        private void FormAgama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agama.Keterangan = textBox1.Text; //Iki sing ate diinputne jal

            int baris = opAgama.insertAgama(agama); //Method e diceluk , parametere objek e 

            if(baris > 0)
            {
                MessageBox.Show("Data Berhasil Disimpan :)");
                loadDataAgama(); // load data grid e , ben iso ngapdet table e langsung
            }
            else
            {
                MessageBox.Show("Data Gagal Disimpan :(");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nek kene settingan datagrid e cek iso di klik
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); //Value tekan data grid index 0 di diuncalne nang label1
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); //Value tekan data grid index 1 di diuncalne nang txtbox1
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agama.Id = Int32.Parse(label1.Text); //Iki gae njumuk ID ne
            opAgama.deleteAgama(agama);
            loadDataAgama();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            agama.Id = Int32.Parse(label2.Text); //Iki gae njumuk ID ne
            agama.Keterangan = textBox1.Text; //Iki sing ate diinputne jal
            opAgama.updateAgama(agama);
            loadDataAgama();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }
    }
}
