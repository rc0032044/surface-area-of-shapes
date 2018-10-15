using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surface_area_of_shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideEverything();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void areaAndVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideEverything();
            button1.Show();
            label1.Show();
            label8.Show();
            textBox1.Show();
            comboBox1.Show();
        }

        private void hideEverything()
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            comboBox1.Hide();
            comboBox2.Hide();
            comboBox3.Hide();
            comboBox4.Hide();

        }

        private void areaAndVolumeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hideEverything();
            button2.Show();
            label2.Show();
            textBox2.Show();
            comboBox2.Show();
        }

        private void areAndVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideEverything();
            button3.Show();
            label3.Show();
            label4.Show();
            textBox4.Show();
            textBox3.Show();
            comboBox3.Show();
        }

        private void areaAndVolumeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hideEverything();
            button4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            textBox5.Show();
            textBox6.Show();
            textBox7.Show();
            comboBox4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                d1 = (4 * Math.PI) * (d1 * d1);
                label8.Text = d1.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                d1 = (4.0 / 3.0 * Math.PI) * (d1 * d1 * d1);
                label8.Text = d1.ToString();
            }
            else
            {
                MessageBox.Show("please select a function fron the drop down menu!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(textBox2.Text);
            if (comboBox2.SelectedIndex == 0)
            {
                d1 = ((d1 * d1) * 6);
                label9.Text = d1.ToString();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                d1 = (d1 * d1 * d1);
                label9.Text = d1.ToString();
            }
            else
            {
                MessageBox.Show("please select a function fron the drop down menu!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(textBox2.Text);
            if (comboBox3.SelectedIndex == 0)
            {
                d1 = ((d1 * d1) * 6);
                label10.Text = d1.ToString();
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                d1 = (d1 * d1 * d1);
                label10.Text = d1.ToString();
            }
            else
            {
                MessageBox.Show("please select a function fron the drop down menu!!");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
