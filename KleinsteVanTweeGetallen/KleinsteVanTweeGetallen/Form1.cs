using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KleinsteVanTweeGetallen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //input
            int getal1, getal2, kleinsteGetal;

            getal1 = int.Parse(getal1Input.Text);
            getal2 = int.Parse(getal2Input.Text);
            kleinsteGetal = Smallest(getal1, getal2);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
