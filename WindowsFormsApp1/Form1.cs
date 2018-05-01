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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dogButton.Checked == true)
            {
                AnimalIdentifier_Base.tagIterator animalTag = new AnimalIdentifier_Base.tagIterator();
                AnimalIdentifier_Base.Dog dog = new AnimalIdentifier_Base.Dog();
                animalTag.TagIterator(textBox1.Text, dog);
                if (dog.returnBool() == true)
                {
                    textBox2.Text = "Yes";
                }
                else
                {
                    textBox2.Text = "No.";
                }
            }
            /*
            else
            {
                textBox2.Text = " ";
            }
            */
            if (catButton.Checked == true)
            {
                AnimalIdentifier_Base.tagIterator animalTag = new AnimalIdentifier_Base.tagIterator();
                AnimalIdentifier_Base.Cat cat = new AnimalIdentifier_Base.Cat();
                animalTag.TagIterator(textBox1.Text, cat);
                if (cat.returnBool() == true)
                {
                    textBox3.Text = "Yes";
                }
                else
                {
                    textBox3.Text = "No.";
                }
            }
            /*
            else
            {
                textBox3.Text = " ";
            }
            */

            if (birbButton.Checked == true)
            {
                AnimalIdentifier_Base.tagIterator animalTag = new AnimalIdentifier_Base.tagIterator();
                AnimalIdentifier_Base.Bird bird = new AnimalIdentifier_Base.Bird();
                animalTag.TagIterator(textBox1.Text, bird);
                if (bird.returnBool() == true)
                {
                    textBox4.Text = "Yes";
                }
                else
                {
                    textBox4.Text = "No.";
                }
            }
            /*
            else
            {
                textBox4.Text = " ";
            }
            */

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
