

using System.Text;
using System;

using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;



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

        public void Number(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text.Length < 16)
            {
                textBox1.Text += b.Text;
                operatorEntered = false;
            }

        }
        private void Operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (!operatorEntered)
            {
                label1.Text = textBox1.Text + " " + b.Text;
                textBox1.Text = "";
                isResultDisplayed = false;
                operatorEntered = true; // Устанавливаем флажок operatorEntered в true
            }

        }
        memory m = new memory();
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
        private void comma()
        {
            if (textBox1.Text.IndexOf(",") == -1)
                textBox1.Text += ",";

        }
        private void button22_Click(object sender, EventArgs e)
        {
            comma();
        }
        private void button8_Click(object sender, EventArgs e)//mc
        {
            m.MC();
        }

        private void button7_Click(object sender, EventArgs e)//mr
        {
            textBox1.Text = m.MR().ToString();
        }

        private void button6_Click(object sender, EventArgs e)//m+
        {
            m.MP(Int32.Parse(textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)//m-
        {
            m.MM(Int32.Parse(textBox1.Text));
        }
        private bool isResultDisplayed = false;

        private void button21_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                return;
            }

            string st = textBox1.Text;
            st = st.Replace("+", " + ");
            st = st.Replace("-", " - ");
            st = st.Replace("%", " % ");
            st = st.Replace("X", " X ");
            st = st.Replace("*", " * ");
            st = st.Replace("/", " / ");
            string[] str2 = label1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            float ans;
            if (str2[1] == "+")
            {
                ans = float.Parse(st) + float.Parse(str2[0]);
                label1.Text = str2[0] + " " + str2[1] + " " + st + " =";
                textBox1.Text = ans.ToString();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
            else if (str2[1] == "-")
            {
                ans = float.Parse(str2[0]) - float.Parse(st);
                label1.Text = str2[0] + " " + str2[1] + " " + st + " =";
                textBox1.Text = ans.ToString();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
            else if (str2[1] == "%" || str2[1] == "/")
            {
                ans = float.Parse(str2[0]) / float.Parse(st);
                label1.Text = str2[0] + " " + str2[1] + " " + st + " =";
                textBox1.Text = ans.ToString();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
            else if (str2[1] == "X" || str2[1] == "*")
            {
                ans = float.Parse(str2[0]) * float.Parse(st);
                label1.Text = label1.Text = str2[0] + " " + str2[1] + " " + st + " =";
                textBox1.Text = ans.ToString();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
            isResultDisplayed = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            isResultDisplayed = false;
            Operation(this.button9, e);
        }


        bool operatorEntered = false;
        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            {
                operatorEntered = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!operatorEntered)
                {
                    button21_Click(sender, e);
                    operatorEntered = false;
                }
            }
            if (e.KeyChar == '*' || e.KeyChar == 'X')
            {
                if (!operatorEntered)
                {
                    Operation(this.button9, e);
                    operatorEntered = true;
                }
            }
            if (e.KeyChar == '%' || e.KeyChar == '/')
            {
                if (!operatorEntered)
                {
                    Operation(this.button4, e);
                    operatorEntered = true;
                }
            }
            if (e.KeyChar == '+')
            {
                if (!operatorEntered)
                {
                    Operation(this.button17, e);
                    operatorEntered = true;
                }
            }
            if (e.KeyChar == '-')
            {
                if (!operatorEntered)
                {
                    Operation(this.button13, e);
                    operatorEntered = true;
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Проверяем наличие только одной запятой
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
            textBox1.Focus();
        }
        //private void button21_Click(object sender, EventArgs e)
        //{

        //}

        private void button17_Click(object sender, EventArgs e)
        {
            isResultDisplayed = false;
            Operation(this.button17, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            isResultDisplayed = false;
            Operation(this.button13, e);

        }
        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isResultDisplayed = false;
            Operation(this.button4, e);
        }
    }
}

