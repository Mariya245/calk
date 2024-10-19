using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)//mc
        {
            memory = 0;
        }

        private void button7_Click(object sender, EventArgs e)//mr
        {
            textBox1.Text = memory.ToString();
        }

        private void button6_Click(object sender, EventArgs e)//m+
        {
            memory += Int32.Parse(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)//m-
        {
            memory -= Int32.Parse(textBox1.Text);
        }
    }
}
