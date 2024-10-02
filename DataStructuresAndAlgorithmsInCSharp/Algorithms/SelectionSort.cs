namespace DataStructuresAndAlgorithmsInCSharp.Algorithms;

public class SelectionSort<T>
{
    public static void SortAscending(T[] arr, Comparer<T> comparer)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (comparer.Compare(arr[j], arr[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]);
            }
        }
    }

    public static void SortDescending(T[] arr, Comparer<T> comparer)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (comparer.Compare(arr[j], arr[maxIndex]) > 0)
                {
                    maxIndex = j;
                }
            }

            if (maxIndex != i)
            {
                (arr[maxIndex], arr[i]) = (arr[i], arr[maxIndex]);
            }
        }
    }
}
