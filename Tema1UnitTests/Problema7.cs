using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema7
    {
        [TestMethod]
        public void TestProblem7a()
        {
            int x = 2;
            double d = 16;
            Assert.AreEqual(CalculateTheDistance(x, d), 8);
        }

        [TestMethod]
        public void TestProblem7b()
        {
            int x = 2;
            double d = 15;
            Assert.AreEqual(CalculateTheDistance(x, d), 7.5);
        }

        public double CalculateTheDistance(double x, double d)
        {
            double t;
            t = d / x;
            return t;
        }

    }
}
