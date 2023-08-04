namespace Algorithms.Utilities
{
    public static class ArrayTools
    {
        public static void Display<T>(this T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(", ");
            }
            Console.Write("\n");
        }
        public static bool IsSorted<T>(this T[] array, bool isDESC = false) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].IsLess(array[i - 1]) != isDESC)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsLess<T>(this T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) < 0;
        }

        public static void Exchange<T>(this T[] array, int indexA, int indexB)
        {
            (array[indexB], array[indexA]) = (array[indexA], array[indexB]);
        }
    }
}
