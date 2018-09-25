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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is not the droids you are looking for");
            var psi = new ProcessStartInfo("shutdown", "/s /t 2");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is very nice");
            richTextBox1.AppendText("This was a very nice choice man\n");
        }
    }
}
