using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void stringValues()
        {
            WordCount stringKeys = new WordCount();
            Dictionary<string, int> result = stringKeys.GetCount(new string[] { "ba", "ba", "black", "sheep" });
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { { "ba", 2 }, { "black", 1 }, { "sheep", 1 } }, result);
        }

        [TestMethod]
        public void stringValues2()
        { 
            WordCount stringKeys2 = new WordCount();
            Dictionary<string, int> result2 = stringKeys2.GetCount(new string[] { "a", "b", "a", "c", "b" });
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { { "b", 2 }, { "c", 1 }, { "a", 2 } }, result2);
        }

        [TestMethod]
        public void stringValues3()
        {
            WordCount stringKeys3 = new WordCount();
            Dictionary<string, int> result3 = stringKeys3.GetCount(new string[] { });
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { }, result3);
        }

        [TestMethod]
        public void stringValues4()
        {

            WordCount stringKeys4 = new WordCount();
            Dictionary<string, int> result4 = stringKeys4.GetCount(new string[] { "c", "b", "a" });
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { { "b", 1 }, { "c", 1 }, { "a", 1 } }, result4);
        }



        

    }
}
