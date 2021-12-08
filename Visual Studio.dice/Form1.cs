using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Studio.dice
{
    
    public partial class Form1 : Form
    {
        float timer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            textBox1.Text = rnd.Next(1, 7).ToString();
            
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox2.Text = rnd.Next(1, 9).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox3.Text = rnd.Next(1, 11).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            windows_for_ form = new windows_for_();
            form.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += timer1.Interval * 0.001f;
            textBox4.Text = "Time Elasped: " + timer.ToString("0.0");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (button5.Items.Count > 0) ;  //if at least one person on the list 
            {
                int StudentNum = rnd.Next(0, button5.Items.Count); //get a random place on list
                textBox1.Text = button5.Items[StudentNum].ToString(); //copy name to textBox

                button5.Items.RemoveAt(StudentNum); //remove the chosen student (optional)
            }

            {
                MessageBox.Show("Josh c, Tom, Kerigan, khalid, Josh b, Josh r, joseph, Tom, Kirin, billy, grace, James, william, matilda, olivia, Jamie, Eshan, Jack");//no students on list :(
            }
    }
}
