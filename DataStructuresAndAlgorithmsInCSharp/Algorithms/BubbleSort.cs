namespace DataStructuresAndAlgorithmsInCSharp.Algorithms
{
    public class BubbleSort<T>
    {
        public static void SortAscending(T[] array, Comparer<T> comparer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }
        }

        public static void SortDescending(T[] array, Comparer<T> comparer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) < 0)
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }
        }
    }
}
