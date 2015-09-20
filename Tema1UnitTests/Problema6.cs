using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema6
    {
        [TestMethod]
        public void TestProblem6()
        {
            int n = 5;
            Assert.AreEqual(CalculateNumberOfRepetitions(n), 25);
        }

        public int CalculateNumberOfRepetitions(int n)
        {
            //repetitions from 1 to n
            int repPart1 = n * (n + 1) / 2;
            //repetitions from (n-1) to 1
            int repPart2 = (n - 1) * n / 2;
            //total number of repetitions
            int noRep = repPart1 + repPart2;
            return noRep;
        }
    }
}
