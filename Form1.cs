using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace form
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value;

            if (int.TryParse(numericUpDown1.Text, out value))
            {
                a = value;
            }
            else
            {
                //Show error message here.
            }
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int value;

            if (int.TryParse(numericUpDown2.Text, out value))
            {
                b = value;
            }
            else
            {
                //Show error message here.
            }

        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int value;

            if (int.TryParse(numericUpDown3.Text, out value))
            {
                c = value;
            }
            else
            {
                //Show error message here.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
