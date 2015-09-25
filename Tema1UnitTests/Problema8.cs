using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema8
    {
        [TestMethod]
        public void TestProblem8()
        {
            int x = 2;
            int y = 3;
            int z = 4;
            int q = 5;
            int w = 6;
            Assert.AreEqual(20, Calculatekg(x, y, z, q, w));
        }

        public int Calculatekg(int x, int y, int z, int q, int w)
        {
            return (z * q * w) / (x * y);
        }
    }
}
