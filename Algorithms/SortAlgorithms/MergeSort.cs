namespace Algorithms.SortAlgorithms
{
    public class MergeSort<T> where T : IComparable<T>
    {
        private T[] aux;

        public void Sort(T[] array)
        {
            aux = new T[array.Length];
            _sort(array, 0, array.Length - 1);
        }

        private void _sort(T[] array, int low, int high)
        {
            //sorting from low index to high index
            //if high <= low  <==> array is already sorted
            if (high <= low)
            {
                return;
            }

            int mid = low / 2 + high / 2;

            //sorting left subarray
            _sort(array, low, mid);

            //sorting right subarray
            _sort(array, mid + 1, high);

            //merging subarrays
            Merge(array, low, mid, high);
        }

        private void Merge(T[] array, int low, int mid, int high)
        {
            //pointerL is the first element of left subarray 
            int pointerL = low;
            //pointerR is the first element of right subarray 
            int pointerR = mid + 1;

            int current = low;

            //copy subarray to aux
            for (int k = low; k <= high; k++)
            {
                aux[k] = array[k];
            }

            while (pointerL <= mid && pointerR <= high)
            {
                if (aux[pointerL].CompareTo(aux[pointerR]) <= 0)
                {
                    array[current] = aux[pointerL];
                    pointerL++;
                }
                else
                {
                    array[current] = aux[pointerR];
                    pointerR++;
                }
                current++;
            }
            while (pointerL <= mid)
            {
                array[current] = aux[pointerL];
                pointerL++;
                current++;

            }
        }
    }
}
