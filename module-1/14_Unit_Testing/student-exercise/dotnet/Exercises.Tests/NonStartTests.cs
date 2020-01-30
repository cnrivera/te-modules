using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]

        public void NonStart()
        {
            NonStart frontEnd = new NonStart();
            string result = frontEnd.GetPartialString("Hello", "There");
            Assert.AreEqual("ellohere", result);

            string result2 = frontEnd.GetPartialString("java", "code");
            Assert.AreEqual("avaode", result2);

            string result3 = frontEnd.GetPartialString("shotl", "java");
            Assert.AreEqual("hotlava", result3);
        }


    }
}
