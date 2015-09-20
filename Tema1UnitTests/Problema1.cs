using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema1
    {
        [TestMethod]
        public void TestProblem1a()
        {
            int m = 6;
            int n = 6;
            int a = 4;
            Assert.AreEqual(CalculateNumberOfPieces(m,n,a), 4);
        }

        [TestMethod]
        public void TestProblem1b()
        {
            int m = 5;
            int n = 5;
            int a = 4;
            Assert.AreEqual(CalculateNumberOfPieces(m, n, a), 4);
        }

        [TestMethod]
        public void TestProblem1c()
        {
            int m = 4;
            int n = 4;
            int a = 4;
            Assert.AreEqual(CalculateNumberOfPieces(m, n, a), 1);
        }

        [TestMethod]
        public void TestProblem1d()
        {
            int m = 5;
            int n = 6;
            int a = 4;
            Assert.AreEqual(CalculateNumberOfPieces(m, n, a), 4);
        }

        public int CalculateNumberOfPieces(int m, int n, int a)
        {
            double x1 = Math.Ceiling((double)m / a);
            double x2 = Math.Ceiling((double)n / a);
            double x = x1 * x2;
            return Convert.ToInt32(x);
        }
    }
}
