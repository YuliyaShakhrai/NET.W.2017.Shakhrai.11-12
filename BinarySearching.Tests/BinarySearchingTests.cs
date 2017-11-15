using System;
using NUnit.Framework;

namespace BinarySearching.Tests
{
    [TestFixture]
    public class BinarySearchingTests
    {
        [Test]
        public void BinarySearchTest_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => BinarySearch.BinarySearching.BinarySearch<int>(null, 5));
        }

        [Test]
        public void BinarySearchTest_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => BinarySearch.BinarySearching.BinarySearch<int>(new int[] { }, 5));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 5, ExpectedResult = 4)]
        [TestCase(new int[] { 9, 10, 11 }, 22, ExpectedResult = -1)]
        public int BinarySearchTest_PositiveTests(int[] array, int element)
        {
            return BinarySearch.BinarySearching.BinarySearch<int>(array, element);
        }
    }
}
