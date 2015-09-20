using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema5
    {
        [TestMethod]
        public void TestProblem5a()
        {
            int x = 6;
            Assert.AreEqual(CanItBeShared(x), "DA");
            int y = 7;
            Assert.AreEqual(CanItBeShared(y), "NU");
        }

        [TestMethod]
        public void TestProblem5b()
        {
            int x = 2;
            Assert.AreEqual(CanItBeShared(x), "NU");
        }

        public string CanItBeShared(int x)
        {
            if (x == 2)
            {
                return "NU";
            }
            if (x % 2 == 0)
            {
                return "DA";
            }
            else
            {
                return "NU";
            }
        }
    }
}
