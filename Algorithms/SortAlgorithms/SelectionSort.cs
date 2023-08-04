using Algorithms.Utilities;

namespace Algorithms.SortAlgorithms
{
    public class SelectionSort
    {
        public void Sort<T>(T[] array) where T : IComparable<T>
        {
            int N = array.Length;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (array[j].IsLess(array[min]))
                    {
                        min = j;
                    }
                }
                array.Exchange(i, min);
            }
        }
    }
}
