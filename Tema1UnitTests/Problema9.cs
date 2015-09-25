using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema9
    {
        [TestMethod]
        public void TestProblem9()
        {
            int n = 9;
            int x = 2;
            List<int> list = GetListWithMushrooms(n, x);
            Assert.AreEqual(3, list[0]);
            Assert.AreEqual(6, list[1]);
        }
        
        public List<int> GetListWithMushrooms(int n, int x)
        {
            int a = n / (x + 1);
            int r = (n * x) / (x + 1);
            List<int> list = new List<int>();
            list.Add(a);
            list.Add(r);
            return list;
        }
    }
}
