using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema4
    {
        [TestMethod]
        public void TestProblem4()
        {
            double credit = 40000;
            double aInterest = 7.57;
            int noMonths = 240;
            int noGivenRates = 39;
            Assert.AreEqual(379, Math.Round(CalculateRate(credit, aInterest, noMonths, noGivenRates)));
        }
        
        public double CalculateRate(double credit, double aInterest, int noMonths, int noGivenRates)
        {
            double ctAmount = credit / noMonths;
            double remainingCredit = credit - (ctAmount * (noGivenRates - 1));
            double interest = (aInterest * remainingCredit) / (12 * 100);
            double rate = ctAmount + interest;
            return rate;
        }
    }
}
