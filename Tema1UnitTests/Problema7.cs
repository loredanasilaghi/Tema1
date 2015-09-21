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
            float d = 16;
            Assert.AreEqual(CalculateTheDistance(x, d), 8);
        }

        [TestMethod]
        public void TestProblem7b()
        {
            int x = 3;
            float d = 15;
            Assert.AreEqual(CalculateTheDistance(x, d), 7.5);
        }

        public float CalculateTheDistance(float x, float d)
        {
            float distanceRemaining = d / 2;
            float cumulativeSpeedOfTrains = 2 * x;
            float trainTime = distanceRemaining / cumulativeSpeedOfTrains;
            float birdDistance = 2 * x * trainTime;
            return birdDistance;
        }

    }
}
