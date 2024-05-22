using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        int a, b, c = 0;

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
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Console.WriteLine("a:" + numericUpDown1.Value.ToString());
            a = Convert.ToInt16(numericUpDown1.Value.ToString());
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Console.WriteLine("b:" + numericUpDown2.Value.ToString());
            b = Convert.ToInt16(numericUpDown2.Value.ToString());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            // Console.WriteLine("c:" + numericUpDown3.Value.ToString());
            c = Convert.ToInt16(numericUpDown3.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mc = new triangle();
            dataGridView1.Rows.Clear();
            if (!(mc.checkValidity(a, b, c)) )
            {
                // Console.WriteLine("Invalid");
                dataGridView1.Rows.Add("Error", "Error");
            }
            else {
                // Console.Write("Perimeter: ");
                var perimeter = mc.Perimeter(a, b, c);
                // Console.WriteLine(perimeter);
                // Console.WriteLine("");

                // Console.Write("Area: ");
                var area = mc.Area(a, b, c);
                // Console.WriteLine(area);
                // Console.WriteLine("");

                // Console.WriteLine("Height: ");
                double heightA = mc.Height(a, b, c, 'a');
                double heightB = mc.Height(a, b, c, 'b');
                double heightC = mc.Height(a, b, c, 'c');
                
                // Console.WriteLine("aH:" + heightA);
                // Console.WriteLine("bH:" + heightB);
                // Console.WriteLine("cH:" + heightC);
                // Console.WriteLine("");

                double alpha = mc.deg(a, b, c, 'a');
                double beta = mc.deg(a, b, c, 'b');
                double gamma = mc.deg(a, b, c, 'c');

                // Console.WriteLine("Alpha:" + alpha);
                // Console.WriteLine("Beta:" + beta);
                // Console.WriteLine("Gamma:" + gamma);
                // Console.WriteLine("");

                string type = mc.nameTri(alpha, beta, gamma);
                // Console.WriteLine("Type:" + type);
                // Console.WriteLine("");

                /*
                // Code for drawing triangle
                Graphics plain;
                plain = this.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.PaleGreen);
                Point[] points = {
                    new Point(10, 10),
                    new Point(10, 10*a),
                    new Point(10, 10)
                };
                
                plain.FillPolygon(brush, points);
                */

                // added date to a table 
                dataGridView1.Rows.Add("A", a);
                dataGridView1.Rows.Add("B", b);
                dataGridView1.Rows.Add("C", c);

                dataGridView1.Rows.Add("Area", area + "²");
                dataGridView1.Rows.Add("Perimeter", perimeter);

                dataGridView1.Rows.Add("Ah", heightA);
                dataGridView1.Rows.Add("Bh", heightB);
                dataGridView1.Rows.Add("Ch", heightC);

                dataGridView1.Rows.Add("Alpha", alpha + "°");
                dataGridView1.Rows.Add("Beta", beta + "°");
                dataGridView1.Rows.Add("gamma", gamma + "°");

                dataGridView1.Rows.Add("Type", type);
            }
        }
    }
}
