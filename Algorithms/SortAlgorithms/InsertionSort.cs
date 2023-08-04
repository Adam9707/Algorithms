using Algorithms.Utilities;

namespace Algorithms.SortAlgorithms
{
    public class InsertionSort
    {
        public void Sort<T>(T[] array) where T : IComparable<T>
        {
            int N = array.Length;
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j > 0 && array[j].IsLess(array[j - 1]); j--)
                {
                    array.Exchange(j, j - 1);
                }
            }
        }
        public void Sort<T>(T[] array, int lo, int hi) where T : IComparable<T>
        {

            for (int i = lo; i <= hi; i++)
            {
                for (int j = i; j > lo && array[j].IsLess(array[j - 1]); j--)
                {
                    array.Exchange(j, j - 1);
                }
            }
        }
    }
}
