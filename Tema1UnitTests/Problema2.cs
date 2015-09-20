using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema2
    {
        [TestMethod]
        public void TestProblem2a()
        {
            int a = 3;
            Assert.AreEqual(Problem2(a), "C");
        }

        [TestMethod]
        public void TestProblem2b()
        {
            int b = 52;
            Assert.AreEqual(Problem2(b), "AZ");
        }

        [TestMethod]
        public void TestProblem2c()
        {
            int c = 703;
            Assert.AreEqual(Problem2(c), "AAA");
        }

        public string Problem2(int x)
        {
            int pos1 = -1;
            int pos2 = -1;
            int pos3 = -1;
            x--;

            List<string> letters = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            pos2 = x / 26 - 1;
            pos3 = x % 26;
            if (pos2 >= 26)
            {
                pos1 = pos2 / 26 - 1;
            }
            string result;
            if (pos1 >= 0)
            {
                pos2 -= 26;
                result = letters[pos1] + letters[pos2] + letters[pos3];
            }
            else if (pos2 >= 0)
            {
                result = letters[pos2] + letters[pos3];
            }
            else
            {
                result = letters[pos3];
            }
            return result;
        }
    }
}
