using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miriamGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _Form1 = this;
        }
        public static Form1 _Form1;
        public void update(string message)
        {
            richTextBox1.AppendText("mess: " + message);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Program sample = new Program();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Exit button

            MessageBox.Show("Goodbye");
            Environment.Exit(0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //No button


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Yes button
            //if ();
            richTextBox1.AppendText("\n");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Save button


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Eat food button


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Drink water button


        }
    }
}
