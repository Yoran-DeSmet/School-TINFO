﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controls instellen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ($" {getal1} ++ {getal2})
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            byte getal1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            byte getal2;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void VraagVerschil_Click(object sender, EventArgs e)
        {

        }"
    }
}
