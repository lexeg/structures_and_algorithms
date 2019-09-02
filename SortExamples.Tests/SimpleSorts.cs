using NUnit.Framework;

namespace SortExamples.Tests
{
    [TestFixture]
    public class SortsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { 5, 3, 6, 7, 4 }, new[] { 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 3, 9, 6, 4, 10, 5, 8, 2, 7, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void BubbleSort_Test(int[] array, int[] destination)
        {
            Sorts.Bubble(ref array);
            Assert.IsTrue(IsArrayEqual(array, destination));
        }

        [Test]
        [TestCase(new[] { 5, 3, 6, 7, 4 }, new[] { 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 3, 9, 6, 4, 10, 5, 8, 2, 7, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void ShaikerSorts_Test(int[] array, int[] destination)
        {
            Sorts.Shaker(ref array);
            Assert.IsTrue(IsArrayEqual(array, destination));
        }

        [Test]
        [TestCase(new[] { 5, 3, 6, 7, 4 }, new[] { 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 3, 9, 6, 4, 10, 5, 8, 2, 7, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void SelectSort_Test(int[] array, int[] destination)
        {
            Sorts.Select(ref array);
            Assert.IsTrue(IsArrayEqual(array, destination));
        }

        [Test]
        [TestCase(new[] { 5, 3, 6, 7, 4 }, new[] { 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 3, 9, 6, 4, 10, 5, 8, 2, 7, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void InserSort_Test(int[] array, int[] destination)
        {
            Sorts.Insert(ref array);
            Assert.IsTrue(IsArrayEqual(array, destination));
        }

        [Test]
        [TestCase(new[] { 5, 3, 6, 7, 4 }, new[] { 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 3, 9, 6, 4, 10, 5, 8, 2, 7, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void InserBinSort_Test(int[] array, int[] destination)
        {
            Sorts.InsertBin(ref array);
            Assert.IsTrue(IsArrayEqual(array, destination));
        }

        [Test]
        [TestCase(new[] { 5, 3, 6, 7, 4 }, new[] { 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 3, 9, 6, 4, 10, 5, 8, 2, 7, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void RecursiveMergeSort_Test(int[] array, int[] destination)
        {
            MergeSort.RecursiveSort(ref array);
            Assert.IsTrue(IsArrayEqual(array, destination));
        }

        private bool IsArrayEqual(int[] source, int[] destination)
        {
            if (source.Length != destination.Length) return false;
            for (var i = 0; i < source.Length; i++)
            {
                if (source[i] != destination[i])
                    return false;
            }
            return true;
        }
    }
}