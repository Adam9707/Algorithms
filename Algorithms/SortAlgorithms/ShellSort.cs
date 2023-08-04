using Algorithms.Utilities;

namespace Algorithms.SortAlgorithms
{
    public enum GapSequence
    {
        Shell,
        Sedgewick
    }
    public class ShellSort
    {
        public void Sort<T>(T[] array, GapSequence gapSequence) where T : IComparable<T>
        {
            int N = array.Length;
            List<int> GapSequenceList;

            switch (gapSequence)
            {
                case GapSequence.Shell:
                    GapSequenceList = GetShellGapSequencesList(N);
                    break;
                case GapSequence.Sedgewick:
                    GapSequenceList = GetSedgewickGapSequencesList(N);
                    break;
                default:
                    GapSequenceList = GetShellGapSequencesList(N);
                    break;
            }

            int gapIterattor = 0;
            int h = GapSequenceList[gapIterattor];

            while (true)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h && array[j].IsLess(array[j - h]); j -= h)
                    {
                        array.Exchange(j, j - h);

                    }
                }
                gapIterattor++;
                if (gapIterattor == GapSequenceList.Count)
                {
                    break;
                }

                h = GapSequenceList[gapIterattor];
            }

        }
        private List<int> GetShellGapSequencesList(int N)
        {
            int i = 1;
            int res = 1;
            var result = new List<int>();
            do
            {
                res = (int)(N / Math.Pow(2, i));
                result.Add(res);
                i++;
            }
            while (res > 1);
            return result;
        }
        public List<int> GetSedgewickGapSequencesList(int N)
        {
            int i = 0;
            int res = 1;
            var result = new List<int>() { 1 };
            do
            {
                res = (int)(Math.Pow(4, i + 1) + 3 * Math.Pow(2, i) + 1);
                result.Add(res);
                i++;
            }
            while (res < N);
            result.Reverse();
            return result;
        }
    }
}
