using Algorithms.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms
{
    public class HeapSort<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            var heap = new Heap<T>(array);
            var i = array.Length - 1;
            while (heap.Count() > 0)
            {
                array[i] = heap.DeleteMax();
                i--;
            }
            int a = 1;
        }

    }
}
