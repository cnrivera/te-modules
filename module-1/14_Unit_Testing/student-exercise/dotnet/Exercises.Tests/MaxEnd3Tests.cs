using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {

        [TestMethod]
        public void RepeatValues()
        {
            MaxEnd3 repeats = new MaxEnd3();
            int[] result = repeats.MakeArray(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result);

            MaxEnd3 repeatsAgain = new MaxEnd3();
            int[] result2 = repeatsAgain.MakeArray(new int[] { 11, 5, 9 });
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, result2);

            MaxEnd3 repeatsTres = new MaxEnd3();
            int[] result3 = repeatsTres.MakeArray(new int[] { 2, 11, 3 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result3);
        }



    }
}
