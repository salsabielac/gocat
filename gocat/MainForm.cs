﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void agamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgama fa = new FormAgama();
            fa.ShowDialog();
        }
    }
}
