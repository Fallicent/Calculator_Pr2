using System;
using Timofeev_lib;

namespace CalcTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestPlus()
        {
            string eq = "2+2";
            string need = "4 ";
            
            Assert.AreEqual(Calc.Go(eq), need, "Неверные расчёты");
        }
        public void TestMinus()
        {
            string eq = "2-2";
            string need = "0 ";

            Assert.AreEqual(Calc.Go(eq), need, "Неверные расчёты");
        }
        public void TestMultiply()
        {
            string eq = "2*2";
            string need = "4 ";

            Assert.AreEqual(Calc.Go(eq), need, "Неверные расчёты");
        }
        public void TestDivide()
        {
            string eq = "2/2";
            string need = "1 ";

            Assert.AreEqual(Calc.Go(eq), need, "Неверные расчёты");
        }
        public void TestPower()
        {
            string eq = "2^2";
            string need = "4 ";

            Assert.AreEqual(Calc.Go(eq), need, "Неверные расчёты");
        }
    }
}
