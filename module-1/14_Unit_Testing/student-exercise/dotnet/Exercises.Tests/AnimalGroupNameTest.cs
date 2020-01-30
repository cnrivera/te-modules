using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void GetHerdAllCapsTest()
        {
            AnimalGroupName animal = new AnimalGroupName();
            string result = animal.GetHerd("ELEPHANT");
            Assert.AreEqual("Herd", result);
        }

        [TestMethod]
        public void GetHerdInitialCapTest()
        {
            AnimalGroupName animal = new AnimalGroupName();
            string result = animal.GetHerd("Giraffe");
            Assert.AreEqual("Tower", result);
        }

        [TestMethod]
        public void GetHerdLowerCaseTest()
        {
            AnimalGroupName animal = new AnimalGroupName();
            string result = animal.GetHerd("crow");
            Assert.AreEqual("Murder", result);
        }

        [TestMethod]
        public void GetHerdEmpty()
        {
            AnimalGroupName animal = new AnimalGroupName();
            string result = animal.GetHerd(" ");
            Assert.AreEqual("unknown", result);
        }
        [TestMethod]
        public void GetHerdNull()
        {
            AnimalGroupName animal = new AnimalGroupName();
            string result = animal.GetHerd(null);
            Assert.AreEqual("unknown", result);
        }

        [TestMethod]
        public void GetHerdRandomCase()
        {
            AnimalGroupName animal = new AnimalGroupName();
            string result = animal.GetHerd("CrocoDILe");
            Assert.AreEqual("Float", result);
        }

    }
}
