using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            textBox1.Text = "";
        }
        int symbol = -1;
        int memory = 0;
        int n1;
        int n2;
        private void Number(int n)//16 
        {
            if (textBox1.Text.Length < 16)
                textBox1.Text += n.ToString();
        }
        private void Symbol(string s)
        {
            if (textBox1.Text != "")
                if ((s == "," || s == "%"))
                {
                    if (textBox1.Text.Length < 16)
                    {
                        if (textBox1.Text.IndexOf(s) == -1)
                            textBox1.Text += s;
                    }
                }
                else
                {
                    label1.Text = textBox1.Text +s;
                    n1 = Int32.Parse(textBox1.Text);
                    textBox1.Text = "";
                }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Number(7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Number(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Number(9);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Number(4);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Number(5);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Number(6);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Number(1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Number(2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Number(3);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Number(0);
        }

        private void button1_Click(object sender, EventArgs e)//%
        {
            Symbol("%");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)//*
        {
            Symbol("*");
        }

        private void button13_Click(object sender, EventArgs e)//-
        {
            Symbol("-");
        }

        private void button17_Click(object sender, EventArgs e)//+
        {
            Symbol("+");
        }

        private void button22_Click(object sender, EventArgs e)//,
        {
            Symbol(",");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)//
        {
            Symbol("/");
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
