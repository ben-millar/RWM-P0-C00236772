using NUnit.Framework;
using UnityEngine;

namespace DecrementIfLessThanFirstTests
{
    public class DecrementIfLessThanFirstFilterTest
    {
        [TestCase(null, null)]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 5, 3, 5, 7, 9, 999 }, new int[] { 5, 2, 5, 7, 9, 999 })]
        [TestCase(new int[] { 0, 3, 5, 7, 9, 999 }, new int[] { 0, 3, 5, 7, 9, 999 })]
        [TestCase(new int[] { 1000, 3, 5, 7, 9, 999 }, new int[] { 1000, 2, 4, 6, 8, 998 })]
        public void DecrementIfLessThanFirstTest(int[] input, int[] expected)
        {
            int[] output = DecrementIfLessThanFirst.decrementIfLessThanFirst(input);

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
