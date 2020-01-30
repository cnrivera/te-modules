using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]

        public void CigarPartyBadPartyTests()
        {
            CigarParty cigarParty = new CigarParty();
            bool result = cigarParty.HaveParty(30, false);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CigarPartyGoodPartyTests()
        {
            CigarParty cigarParty = new CigarParty();
            bool result = cigarParty.HaveParty(50, false);
            Assert.AreEqual(true, result);
           
        }

        [TestMethod]
        public void CigarPartyWeekendTests()
        {
            CigarParty cigarParty = new CigarParty();
            bool result = cigarParty.HaveParty(70, true);
            Assert.AreEqual(true, result);

        }

    }
}
