using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1UnitTests
{
    [TestClass]
    public class UnitTests
    {
        Tema1.Program program = new Tema1.Program();

        [TestMethod]
        public void TestProblem1()
        {
            int m = 6;
            int n = 6;
            int a = 4;
            Assert.AreEqual(program.Problem1(m,n,a), 4);
        }

        [TestMethod]
        public void TestProblem2()
        {
            int a = 3;
            Assert.AreEqual(program.Problem2(a), "C");
            int b = 52;
            Assert.AreEqual(program.Problem2(b), "AZ");
            int c = 703;
            Assert.AreEqual(program.Problem2(c), "AAA");
        }

        [TestMethod]
        public void TestProblem5()
        {
            int x = 6;
            Assert.AreEqual(program.Problem5(x), "DA");
            int y = 7;
            Assert.AreEqual(program.Problem5(y), "NU");
        }

        [TestMethod]
        public void TestProblem8()
        {
            int x = 2;
            int y = 3;
            int z = 4;
            int q = 5;
            int w = 6;
            Assert.AreEqual(program.Problem8(x, y, z, q, w), 20);
        }
        [TestMethod]
        public void TestProblem9()
        {
            int n = 9;
            int x = 2;
            List<int> list = program.Problem9(n, x);
            Assert.AreEqual(list[0], 3);
            Assert.AreEqual(list[1], 6);
        }
    }
}
