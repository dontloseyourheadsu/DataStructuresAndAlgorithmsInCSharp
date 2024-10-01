namespace DataStructuresAndAlgorithmsInCSharp.Algorithms;

public class SelectionSort
{
    public static void SortAscending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
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

    public static void SortDescending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > arr[maxIndex])
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
