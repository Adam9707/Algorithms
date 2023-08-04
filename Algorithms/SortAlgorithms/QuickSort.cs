using Algorithms.Utilities;

namespace Algorithms.SortAlgorithms
{
    public class QuickSort<T> where T : IComparable<T>
    {
        InsertionSort Insertion;
        private int _m;

        public QuickSort()
        {
            Insertion = new InsertionSort();
            _m = 0;
        }

        public void Sort(T[] array)
        {
            if (array.Length == 0) return;
            Sort(array, 0, array.Length - 1);
        }
        public void HybridSort(T[] array, int m)
        {
            if (array.Length == 0) return;
            _m = m;
            HybridSort(array, 0, array.Length - 1);
        }
        private void HybridSort(T[] array, int lo, int hi)
        {
            if (hi <= lo + _m)
            {
                Insertion.Sort(array, lo, hi);
                return;
            }
            int j = Partition(array, lo, hi);
            HybridSort(array, lo, j - 1); // left side
            HybridSort(array, j + 1, hi); // right side
        }
        private void Sort(T[] array, int lo, int hi)
        {
            if (hi <= lo) return;
            int j = Partition(array, lo, hi);
            Sort(array, lo, j - 1); // left side
            Sort(array, j + 1, hi); // right side
        }

        private int Partition(T[] array, int lo, int hi)
        {
            int i = lo; int j = hi + 1;
            T v = array[lo];
            while (true)
            {
                while (array[++i].IsLess(v)) if (i == hi) break;
                while (v.IsLess(array[--j])) if (j == lo) break;
                if (i >= j) break;
                array.Exchange(i, j);
            }
            array.Exchange(lo, j);
            return j;
        }
    }
}
