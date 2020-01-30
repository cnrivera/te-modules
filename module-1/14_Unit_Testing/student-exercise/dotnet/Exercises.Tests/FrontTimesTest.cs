using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void TwoLong()
        {
            FrontTimes frontTimes = new FrontTimes();
            string result = frontTimes.GenerateString("Chocolate", 2);
            Assert.AreEqual("ChoCho", result);
        }

        [TestMethod]
        public void ThreeLong()
        {
            FrontTimes frontTimes = new FrontTimes();
            string result = frontTimes.GenerateString("Chocolate", 3);
            Assert.AreEqual("ChoChoCho", result);
        }

        [TestMethod]
        public void LessThree()
        {
            FrontTimes frontTimes = new FrontTimes();
            string result = frontTimes.GenerateString("abc", 3);
            Assert.AreEqual("abcabcabc", result);
        }


    }
}
