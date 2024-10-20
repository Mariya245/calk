using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        }


        bool operatorEntered = false;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
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
            if (e.KeyChar == '*' || e.KeyChar == (char)Keys.X)
            {
                if (!operatorEntered)
                {
                    button9_Click(sender, e);
                    operatorEntered = true;
                }
            }
            if (e.KeyChar == '%' || e.KeyChar == '/')
            {
                if (!operatorEntered)
                {
                    button1_Click(sender, e);
                    operatorEntered = true;
                }
            }
            if (e.KeyChar == '+')
            {
                if (!operatorEntered)
                {
                    button17_Click(sender, e);
                    operatorEntered = true;
                }
            }
            if (e.KeyChar == '-')
            {
                if (!operatorEntered)
                {
                    button13_Click(sender, e);
                    operatorEntered = true;
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // ѕровер€ем наличие только одной зап€той
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isResultDisplayed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            isResultDisplayed = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            isResultDisplayed = false;
        }
    }
}
