using System;
using WinFormsApp1;
namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            memory m = new memory();
            m.MC();
            m.MP(1);
            Assert.AreEqual(1,m.MR());

            m.MC();
            m.MP(2147483647);
            Assert.AreEqual(2147483647, m.MR());

            m.MC();
            m.MP(-2147483648);
            Assert.AreEqual(-2147483648, m.MR());



            m.MC();
            m.MM(2147483647);
            Assert.AreEqual(-2147483647, m.MR());

            m.MC();
            m.MM(-2147483647);
            Assert.AreEqual(2147483647, m.MR());

            m.MC();
            m.MP(215);
            Assert.AreEqual(215, m.MR());

            m.MC();
            m.MP(5);
            m.MP(5);
            m.MP(5);
            Assert.AreEqual(15, m.MR());

            m.MC();
            Assert.AreEqual(0, m.MR());

            m.MC();
            m.MM(5);
            m.MM(5);
            Assert.AreEqual(-10, m.MR());


        }
    }
}