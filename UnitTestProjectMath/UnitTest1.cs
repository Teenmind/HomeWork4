using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork4;

namespace UnitTestProjectMath
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(45, 10, 10.24)]
        public void TestDistanseOfShotDegree(int degree, double speed, double exp)
        {
            double act = MathTasks.DistanseOfShotDegree(degree, speed);
            Assert.AreEqual(exp, act, 0.01);
        }

        [DataTestMethod]
        [DataRow(2, 2, 0, 1, 4)]
        [DataRow(2, 3, 2, 2, 12)]

        public void TestDistanseBetweenCars(double v1, double v2, double s, double t, double exp)
        {
            double act = MathTasks.DistanseBetweenCars(v1, v2, s, t);
            Assert.AreEqual(exp, act, 0.01);
        }

        [DataTestMethod]
        [DataRow(-2, 3, 2, 2, 12)]
        [DataRow(2, -3, 2, 2, 12)]
        [DataRow(2, 3, -2, 2, 12)]
        [DataRow(2, 3, 2, -2, 12)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDistanseBetweenCarsException(double v1, double v2, double s, double t, double exp)
        {
            double act = MathTasks.DistanseBetweenCars(v1, v2, s, t);
        }

        [DataTestMethod]
        [DataRow(2, 2, true)]
        [DataRow(10, 10, false)]
        [DataRow(0,0, true)]
        [DataRow(1,0, true)]
        [DataRow(1, 2, true)]
        public void TestInsideCrossedArea(double x, double y, bool exp)
        {
            bool act = MathTasks.InsideCrossedArea(x, y);
            Assert.AreEqual(exp, act);
        }

        [DataTestMethod]
        [DataRow(0, 1)]
        public void TestCalculateExpression(double x, double exp)
        {
            double act = MathTasks.CalculateExpression(x);
            Assert.AreEqual(exp, act, 0.01);
        }
    }
}
