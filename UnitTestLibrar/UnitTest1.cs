using Microsoft.VisualStudio.TestTools.UnitTesting;
using SF2022User;
using System;

namespace UnitTestLibrar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TimeSpan[] startTimes = { };
            int[] durations = { };
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);
            int consultationTime = 30;

            string[] result = Calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            Assert.AreEqual(0, result.Length);
        }
        [TestMethod]
        public void Test2_NotEnoughTimeAtStartOfWorkingDay()
        {
            // Arrange
            TimeSpan[] startTimes = { new TimeSpan(9, 30, 0) };
            int[] durations = { 30 };
            TimeSpan beginWorkingTime = new TimeSpan(9, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(11, 0, 0);
            int consultationTime = 45;

            // Act
            string[] result = Calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            // Assert
            Assert.AreEqual(0, result.Length);
        }
    }
}
