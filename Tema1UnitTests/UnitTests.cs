﻿using System;
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
        public void TestProblem1a()
        {
            int m = 6;
            int n = 6;
            int a = 4;
            Assert.AreEqual(program.Problem1(m,n,a), 4);
        }

        [TestMethod]
        public void TestProblem1b()
        {
            int m = 5;
            int n = 5;
            int a = 4;
            Assert.AreEqual(program.Problem1(m, n, a), 4);
        }

        [TestMethod]
        public void TestProblem1c()
        {
            int m = 4;
            int n = 4;
            int a = 4;
            Assert.AreEqual(program.Problem1(m, n, a), 1);
        }

        [TestMethod]
        public void TestProblem1d()
        {
            int m = 5;
            int n = 6;
            int a = 4;
            Assert.AreEqual(program.Problem1(m, n, a), 4);
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
        public void TestProblem3a()
        {
            double x1 = 0.000000;
            double y1 = 0.000000;
            double x2 = 1.000000;
            double y2 = 1.000000;
            double x3 = 0.000000;
            double y3 = 1.000000;
            Assert.AreEqual(program.Problem3(x1, y1, x2, y2, x3, y3), 1.000000);
        }

        [TestMethod]
        public void TestProblem3b()
        {
            double xx1 = 0.000000;
            double yy1 = 0.000000;
            double xx2 = 0.000000;
            double yy2 = 3.000000;
            double xx3 = 4.000000;
            double yy3 = 0.000000;
            Assert.AreEqual(program.Problem3(xx1, yy1, xx2, yy2, xx3, yy3), 12.000000);
        }

        [TestMethod]
        public void TestProblem4()
        {
            double credit = 40000;
            double aInterest = 7.57;
            int noMonths = 240;
            int noGivenRates = 39;
            Assert.AreEqual(Math.Round(program.Problem4(credit, aInterest, noMonths, noGivenRates)),379);
        }
        
        [TestMethod]
        public void TestProblem5a()
        {
            int x = 6;
            Assert.AreEqual(program.Problem5(x), "DA");
            int y = 7;
            Assert.AreEqual(program.Problem5(y), "NU");
        }

        [TestMethod]
        public void TestProblem5b()
        {
            int x = 2;
            Assert.AreEqual(program.Problem5(x), "NU");
        }

        [TestMethod]
        public void TestProblem6()
        {
            int n = 5;
            Assert.AreEqual(program.Problem6(n), 25);
        }

        [TestMethod]
        public void TestProblem7a()
        {
            int x = 2;
            double d = 16;
            Assert.AreEqual(program.Problem7(x, d), 8);
        }

        [TestMethod]
        public void TestProblem7b()
        {
            int x = 2;
            double d = 15;
            Assert.AreEqual(program.Problem7(x, d), 7.5);
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

        [TestMethod]
        public void TestProblem10()
        {
            int n = 5;
            int m = 6;
            int a = 2;
            int b = 4;
            Assert.AreEqual(program.Problem10(n, m, a, b), 5);
        }

        [TestMethod]
        public void TestProblem10b()
        {
            int n = 7;
            int m = 9;
            int a = 2;
            int b = 3;
            Assert.AreEqual(program.Problem10(n, m, a, b), 13);
        }
    }
}
