using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema10
    {
        [TestMethod]
        public void TestProblem10a()
        {
            int n = 5;
            int m = 6;
            int a = 2;
            int b = 4;
            Assert.AreEqual(CalculateNumberOfBoards(n, m, a, b), 5);
        }

        [TestMethod]
        public void TestProblem10b()
        {
            int n = 7;
            int m = 9;
            int a = 2;
            int b = 3;
            Assert.AreEqual(CalculateNumberOfBoards(n, m, a, b), 13);
        }

        public int CalculateNumberOfBoards(int n, int m, int a, int b)
        {
            //whole floor, including losses
            double area = (n * m) + (0.15 * n * m);
            double board = a * b;
            double noBoards = Math.Ceiling(area / board);
            return Convert.ToInt32(noBoards);
        }
    }
}
