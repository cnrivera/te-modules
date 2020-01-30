using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]

    public class StringBitsTests
    {

        [TestMethod]
        public void GetTheBits()
        {
           StringBits stringBits = new StringBits();
           string result = stringBits.GetBits("Hello");
           Assert.AreEqual("Hlo", result);

            StringBits stringBits2 = new StringBits();
            string result2 = stringBits2.GetBits("Hi");
            Assert.AreEqual("H", result2);

            StringBits stringBits3 = new StringBits();
            string result3 = stringBits3.GetBits("Heeololeo");
            Assert.AreEqual("Hello", result3);
        }
       


    }
}
