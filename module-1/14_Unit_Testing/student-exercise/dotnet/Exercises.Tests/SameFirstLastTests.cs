using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void ArrayLength()
        {
            SameFirstLast arrayLength = new SameFirstLast();
            bool result = arrayLength.IsItTheSame(new int[] { 1, 2, 3 });
            Assert.AreEqual(false, result);

            SameFirstLast arrayLengthEqual = new SameFirstLast();
            bool result2 = arrayLength.IsItTheSame(new int[] { 1, 2, 3, 1 });
            Assert.AreEqual(true, result2);

            SameFirstLast arrayLengthEqualShort = new SameFirstLast();
            bool result3 = arrayLength.IsItTheSame(new int[] { 1, 2, 1 });
            Assert.AreEqual(true, result3);



        }
    }
}
