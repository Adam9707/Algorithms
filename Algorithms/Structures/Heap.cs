using Algorithms.Utilities;

namespace Algorithms.Structures
{
    public class Heap<T> where T : IComparable<T>
    {
        private T[] _heap;
        private int _size; // numbers of elements on heap, _heap[0] is unasign. 
        public Heap(int maxN)
        {
            _heap = new T[maxN + 1];
        }
        public Heap(T[] aux) 
        {
            _heap = new T[aux.Count() + 1];
            foreach (T t in aux)
            {
                this.Add(t);
            }
        }
        public bool IsEmpty()
        {
            return _size == 0;
        }
        public int Count()
        {
            return _size;
        }
        public void Add(T item)
        {
            _heap[++_size] = item;
            swim(_size);
        }
        public T DeleteMax()
        {
            T max = _heap[1];
            _heap.Exchange(1, _size--);
            _heap[_size+1] = default; 
            sink(1);
            return max;
        }

        private void sink(int k)
        {
            while(2*k <= _size)
            {
                int j = 2 * k;
                if(j < _size && _heap[j].IsLess(_heap[j + 1]))
                {
                    j++;
                }
                if (!_heap[k].IsLess(_heap[j]))
                {
                    break;
                }
                _heap.Exchange(k, j);
                k = j;
            }
        }

        //array method
        private void exch(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private void swim(int k)
        {
            while (k>1 && _heap[k / 2].IsLess(_heap[k]))
            {
                _heap.Exchange(k/2,k);
                k=k/2;
            }
        }
    }
}
