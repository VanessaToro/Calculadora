using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using TestCalculator.Controllers;
using System.Web;

namespace TestCalculatorUnitTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class CalculatorControllerTest
    {
        [TestMethod]
        public void GetSum()
        {
            CalculatorController ctrl = new CalculatorController();
            string num1 = "25";
            string num2 = "11";
            string num3 = "5";

            var resultEsperado = "41";
            var resultApp = ctrl.GetSum(num1, num2, num3);

            Assert.AreEqual(resultEsperado, resultApp);
        }

        [TestMethod]
        public void GetSustraction()
        {
            CalculatorController ctrl = new CalculatorController();
            string num1 = "108";
            string num2 = "20";
            string num3 = "8";

            var resultEsperado = "80";
            var resultApp = ctrl.GetSustration(num1, num2, num3);

            Assert.AreEqual(resultEsperado, resultApp);
        }

        [TestMethod]
        public void GetMultiplicacion()
        {
            CalculatorController ctrl = new CalculatorController();
            string num1 = "25";
            string num2 = "9";
            string num3 = "0";

            var resultEsperado = "80";
            var resultApp = ctrl.GetMultiplication(num1, num2, num3);

            Assert.AreEqual(resultEsperado, resultApp);
        }

        [TestMethod]
        public void GetDivition()
        {
            CalculatorController ctrl = new CalculatorController();
            string num1 = "111";
            string num2 = "8";
            string num3 = "2";

            var resultEsperado = "6,9375";
            var resultApp = ctrl.GetDivision(num1, num2, num3);

            Assert.AreEqual(resultEsperado, resultApp);
        }

        [TestMethod]
        public void GetRaiz()
        {
            CalculatorController ctrl = new CalculatorController();
            string num1 = "5";
            string num2 = "0";
            string num3 = "0";

            var resultEsperado = "2.23606797749979";
            var resultApp = ctrl.GetRaizCuadrada(num1, num2, num3);

            Assert.AreEqual(resultEsperado, resultApp);
        }
    }
}
