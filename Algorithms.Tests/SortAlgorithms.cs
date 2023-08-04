using Algorithms.SortAlgorithms;
using Algorithms.Utilities;
using FluentAssertions;

namespace Algorithms.Tests
{
    public class SortAlgorithms
    {
        private int[] array;
        private Random rnd;
        [SetUp]
        public void Setup()
        {
            rnd = new Random();
            array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,100);
            }
        }

        [Test]
        public void SelectionSort()
        {
            var selectionSort = new SelectionSort();
            selectionSort.Sort(array);
            array.IsSorted().Should().BeTrue();
        }

        [Test]
        public void InsertionSort()
        {
            var insertionSort = new InsertionSort();
            insertionSort.Sort(array);
            array.IsSorted().Should().BeTrue();
        }

        [Test]
        public void ShellSort()
        {
            var shellSort = new ShellSort();
            shellSort.Sort(array, GapSequence.Shell);
            array.IsSorted().Should().BeTrue();
        }
        [Test]
        public void ShellSortSedgewickGaps()
        {
            var shellSort = new ShellSort();
            shellSort.Sort(array, GapSequence.Sedgewick);
            array.IsSorted().Should().BeTrue();
        }
        [Test]
        public void MergeSort()
        {
            var mergeSort = new MergeSort<int>();
            mergeSort.Sort(array);
            array.IsSorted().Should().BeTrue();
        }
        [Test]
        public void QuickSort()
        {
            var mergeSort = new QuickSort<int>();
            mergeSort.Sort(array);
            array.IsSorted().Should().BeTrue();
        }
        [Test]
        public void HybridQuickSort()
        {
            var mergeSort = new QuickSort<int>();
            mergeSort.HybridSort(array, 5);
            array.IsSorted().Should().BeTrue();
        }
        [Test]
        public void HeapSort()
        {
            var heapSort = new HeapSort<int>();
            heapSort.Sort(array);
            array.IsSorted().Should().BeTrue();
        }
    }
}
