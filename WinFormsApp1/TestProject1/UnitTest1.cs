using System.Windows.Forms;
using System;
using WinFormsApp1;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form = new Form1();
            KeyPressEventArgs e = new KeyPressEventArgs('a');
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsTrue(e.Handled);

            e = new KeyPressEventArgs('.');
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsTrue(e.Handled);

            e = new KeyPressEventArgs('5');
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsFalse(e.Handled);

            e = new KeyPressEventArgs(',');
            form.textBox1.Text = "12,3";
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsTrue(e.Handled);

            e = new KeyPressEventArgs('+');
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsTrue(e.Handled);

            e = new KeyPressEventArgs('-');
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsTrue(e.Handled);

            e = new KeyPressEventArgs('*');
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsTrue(e.Handled);

            e = new KeyPressEventArgs('X');
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsTrue(e.Handled);

            e = new KeyPressEventArgs('%');
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsTrue(e.Handled);

            e = new KeyPressEventArgs('/');
            form.textBox1_KeyPress(form.textBox1, e);
            Assert.IsTrue(e.Handled);

        }
    }
}