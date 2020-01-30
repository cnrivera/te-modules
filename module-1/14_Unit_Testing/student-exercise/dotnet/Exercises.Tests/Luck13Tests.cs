using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Luck13Tests
    {
        [TestMethod]
        public void NoOnesThrees()
        {
            Lucky13 noOnesThrees = new Lucky13();
            bool result = noOnesThrees.GetLucky(new int[] {0, 2, 4 });
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void HasBoth()
        {
            Lucky13 hasboth = new Lucky13();
            bool result = hasboth.GetLucky(new int[] { 1, 2, 3 });
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void HasOnes()
        {
            Lucky13 hasOnes = new Lucky13();
            bool result = hasOnes.GetLucky(new int[] { 1, 2, 4 });
            Assert.AreEqual(false, result);
        }
    }


    
}
