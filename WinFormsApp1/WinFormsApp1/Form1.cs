namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        memory m = new memory();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)//mc
        {
            m.MC();
        }

        private void button7_Click(object sender, EventArgs e)//mr
        {
           textBox1.Text= m.MR().ToString();
        }

        private void button6_Click(object sender, EventArgs e)//m+
        {
            m.MP(Int32.Parse(textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)//m-
        {
            m.MM(Int32.Parse(textBox1.Text));
        }
    }
}
