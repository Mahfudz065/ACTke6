﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1  dp = new Form1();
            dp.Show();
            this.Hide();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataMahasiswa dm = new DataMahasiswa();
            dm.Show();
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataStatusMahasiswa sm = new DataStatusMahasiswa();
            sm.Show();
            this.Hide();

        }

        private void dataProdiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataProdi dp = new 
        }
    }
}