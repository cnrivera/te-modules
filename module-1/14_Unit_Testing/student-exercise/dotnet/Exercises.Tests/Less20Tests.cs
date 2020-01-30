using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [TestMethod]
        public void OneLessTwenty()
        {
            Less20 oneLess = new Less20();
            bool result = oneLess.IsLessThanMultipleOf20(19);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TwoLessTwenty()
        {
            Less20 twoLess = new Less20();
            bool result = twoLess.IsLessThanMultipleOf20(18);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsTwenty()
        {
            Less20 isTwenty = new Less20();
            bool result = isTwenty.IsLessThanMultipleOf20(20);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void MuchLessTwenty()
        {
            Less20 muchLess = new Less20();
            bool result = muchLess.IsLessThanMultipleOf20(15);
            Assert.AreEqual(false, result);
        }
    }
}
