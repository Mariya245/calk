
using System.Text;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "";

            label1.Location = new Point(10, 61);
        }
        private void Number(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text.Length < 16)
                textBox1.Text += b.Text;

        }
        private void Operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            label1.Text = textBox1.Text + b.Text;
            textBox1.Text = "";


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comma() {
            if (textBox1.Text.IndexOf(",") == -1)
                textBox1.Text += ",";

        }
        private void button22_Click(object sender, EventArgs e)
        {
            comma();
        }
    }
}
