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
        }

		public void Superlooper()
	    {
			List<string> events = new List<string>();
			events.Add("You find an abandoned caravan do you look to find something");
			events.Add("You find an abandoned car do you want to search it");
			events.Add("Theres a wanderer in your path do you approach him");

			Random rnd = new Random();
			int randomEvent = rnd.Next(0, 2); //Creates random number between 0 and 2

			var firstItem = events[randomEvent];

			int hunger = 15;
			int thirst = 7;

			if (hunger > 0 && thirst > 0)
			{
				string hungerStr = hunger.ToString();
				string thirstStr = thirst.ToString();
				richTextBox1.AppendText(firstItem);
				richTextBox1.AppendText("\nYou have " + hungerStr + " hunger left\n" + "You have " + thirstStr + " thirst left\n");
				hunger--;
				thirst--;
			}
			else
			{
				richTextBox1.AppendText("You Died\n");
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
            //Exit button

            MessageBox.Show("Goodbye");
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //No button


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Yes button
            //if () ;
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

		private void Form1_Load(object sender, EventArgs e)
		{
			Superlooper();
		}
	}
}
