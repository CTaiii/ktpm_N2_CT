using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UNitTest_CT_43;


namespace CalcTest_CT_43
{
    [TestClass]
    public class UTest_CT_43
    {
        private Calc_CT_43 c;
        public TestContext TestContext { get; set; }
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp_CT_43()
        {
            c = new Calc_CT_43(9, 4);
        }
        [TestMethod] // TC1: a = 9, b = 4 , kq = 13
        public void Cong_CT_43()
        {
            int expected, actual;
            // Calc_CT_43 c = new Calc_CT_43 (a,b)
            expected = 13;
            actual = c.X_CT_43("+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Tru_CT_43()
        {
            int expected, actual;
            // Calc_CT_43 c = new Calc_CT_43 (a,b)
            expected = 5;
            actual = c.X_CT_43("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Nhan_CT_43()
        {
            int expected, actual;
            // Calc_CT_43 c = new Calc_CT_43 (a,b)
            expected = 36;
            actual = c.X_CT_43("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Chia_CT_43()
        {
            int expected, actual;
            c = new Calc_CT_43(10, 5);
            expected = 2;
            actual = c.X_CT_43("/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Chia0_CT_43()
        {
            c = new Calc_CT_43(8, 0);
            c.X_CT_43("/");

        }

        [TestMethod]

        // Lien ket TestData voi ProJect
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV"
                    , @".\Data\TestData_CT_43.csv"
                    , "TestData_CT_43#csv", DataAccessMethod.Sequential)]
        public void CongWithData_CT_43()
        {
            int a, b, expected, actual;
            string Calc;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            Calc = TestContext.DataRow[2].ToString();
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c = new Calc_CT_43(a, b);
            actual = c.X_CT_43(String.Format("{0}",Calc));
            Assert.AreEqual(expected, actual);
        }

    }
}
