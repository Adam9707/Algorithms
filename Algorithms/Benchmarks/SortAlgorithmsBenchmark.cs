using Algorithms.SortAlgorithms;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmarks
{
    [MemoryDiagnoser]
    public class SortAlgorithmsBenchmark
    {

        Random rnd = new Random();
        private int[] array;

        // [Params(3, 4, 5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20)]
        [Params(10000, 100000, 1000000)]

        public int N;

        [GlobalSetup]
        public void GlobalSetup()
        {
            array = new int[N];
        }
        [IterationSetup]
        public void IterationSetup()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }
        }

        //  [Benchmark(Baseline = true)]
        public void SelectionSort()
        {
            var selectionSort = new SelectionSort();
            selectionSort.Sort(array);
        }

        //  [Benchmark(Baseline = true)]
        public void InsertionSort()
        {
            var insertionSort = new InsertionSort();
            insertionSort.Sort(array);
        }

        //[Benchmark(Baseline = true)]
        public void ShellSort()
        {
            var shellSort = new ShellSort();
            shellSort.Sort(array, GapSequence.Shell);
        }
        //[Benchmark]
        public void ShellSortSedgewickGaps()
        {
            var shellSort = new ShellSort();
            shellSort.Sort(array, GapSequence.Sedgewick);
        }
        //[Benchmark]
        public void MergeSort()
        {
            var mergeSort = new MergeSort<int>();
            mergeSort.Sort(array);
        }
        [Benchmark(Baseline = true)]
        public void QuickSort()
        {
            var mergeSort = new QuickSort<int>();
            mergeSort.Sort(array);
        }
        [Benchmark]
        public void HybridQuickSort()
        {
            var mergeSort = new QuickSort<int>();
            mergeSort.HybridSort(array, 10);
        }

        [Benchmark]
        public void HeapSort()
        {
            var heapSort = new HeapSort<int>();
            heapSort.Sort(array);
        }
    }

}
