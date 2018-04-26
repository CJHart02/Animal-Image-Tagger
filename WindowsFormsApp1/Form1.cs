using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool dogChecked;
        private bool catChecked;
        private bool birdChecked;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            string fullpath;
            fullpath = Path.GetFullPath(openFileDialog1.FileName);
            textBox1.Text = fullpath;

            Console.WriteLine(result); // <-- For debugging use.
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             
            if (dogButton.Checked == true)
            {
                dogChecked = true;
            }
            if (dogButton.Checked == false)
            {
                dogChecked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (catButton.Checked == true)
            {
                catChecked = true;
            }
            if (dogButton.Checked == false)
            {
                catChecked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (birbButton.Checked == true)
            {
                birdChecked = true;
            }
            if (dogButton.Checked == false)
            {
                birdChecked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (dogChecked == true)
            {

            }

            if (catChecked == true)
            {

            }

            if (birdChecked == true)
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
