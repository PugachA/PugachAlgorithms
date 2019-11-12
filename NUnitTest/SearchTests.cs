using NUnit.Framework;
using PugachAlgorithms;

namespace NUnitTest
{
    public class SearchTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 ,4, 5 ,6}, 6, 5)]
        [TestCase(new int[] { 1, 10, 55 ,54, 105 ,10}, 10, 1)]
        public void SimpleSearch_ShouldReturnCorrectResult(int[] mas, int searchingElement, int expectedIndex)
        {
            Assert.AreEqual(expectedIndex, Search.SearchSimple(mas, searchingElement));
        }
    }
}