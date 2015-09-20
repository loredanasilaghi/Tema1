using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema1UnitTests
{
    [TestClass]
    public class Problema3
    {
        [TestMethod]
        public void TestProblem3RectangleAreaA()
        {
            Coordinates x = new Coordinates(0.000000, 0.000000);
            Coordinates y = new Coordinates(1.000000, 1.000000);
            Coordinates z = new Coordinates(0.000000, 1.000000);
            Assert.AreEqual(CalculateArea(x, y, z), 1.000000);
        }

        [TestMethod]
        public void TestProblem3RectangleAreaB()
        {
            Coordinates x = new Coordinates(0.000000, 0.000000);
            Coordinates y = new Coordinates(0.000000, 3.000000);
            Coordinates z = new Coordinates(4.000000, 0.000000);
            Assert.AreEqual(CalculateArea(x, y, z), 12.000000);
        }

        [TestMethod]
        public void TestProblem3TriangleArea()
        {
            Coordinates x = new Coordinates(0.000000, 0.000000);
            Coordinates y = new Coordinates(1.000000, 1.000000);
            Coordinates z = new Coordinates(0.000000, 1.000000);
            Assert.AreEqual(Math.Round(CalculateTraingleArea(x, y, z), 1), 0.500000);
        }

        public struct Coordinates
        {
            public double x, y;

            public Coordinates(double p1, double p2)
            {
                x = p1;
                y = p2;
            }
        }

        public double CalculateArea(Coordinates x, Coordinates y, Coordinates z)
        {
            double area;
            double l1 = CalculateDistance(x, z);
            double l2 = CalculateDistance(y, z);
            double l3 = CalculateDistance(x, y);
            if ((l1 > l2) && (l1 > l3))
            {
                area = l2 * l3;
            }
            else if ((l2 > l3) && (l2 > l1))
            {
                area = l1 * l3;
            }
            else
            {
                area = l1 * l2;
            }
            return area;
        }
        
        public double CalculateDistance(Coordinates z, Coordinates t)
        {
            double a = CalculateExp(z.x, t.x) + CalculateExp(z.y, t.y);
            double b = Math.Sqrt(a);
            return b;
        }

        public double CalculateExp(double z1, double z2)
        {
            double a = z1 - z2;
            return Math.Pow(a, 2);
        }

        public double CalculateTraingleArea(Coordinates x, Coordinates y, Coordinates z)
        {
            double triangleArea;
            double l1 = CalculateDistance(x, z);
            double l2 = CalculateDistance(y, z);
            double l3 = CalculateDistance(x, y);
            double p = (l1 + l2 + l3) / 2;
            triangleArea = Math.Sqrt(p * (p - l1) * (p - l2) * (p - l3));
            return triangleArea;
        }
    }
}
