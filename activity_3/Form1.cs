using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String answer = "";
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            answer += "Python\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            answer += "Java\n";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            answer += "C++\n";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            answer += "C\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true)
            {
                MessageBox.Show("You selected\n" + answer);
            }
            else
            {
                MessageBox.Show("You selected\n" + textBox1.Text+"\n" + answer);
            }
        }

        private void Others_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }
    }
}
