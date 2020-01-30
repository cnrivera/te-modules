using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {

        [TestMethod]
        public void GotATable()
        {
            DateFashion table = new DateFashion();
            int result = table.GetATable(5, 10);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GotNoTable()
        {
            DateFashion table = new DateFashion();
            int result = table.GetATable(5, 2);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void MaybeATable()
        {
            DateFashion table = new DateFashion();
            int result = table.GetATable(5, 5);
            Assert.AreEqual(1, result);
        }
    }
}
