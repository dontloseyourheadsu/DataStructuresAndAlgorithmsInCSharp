using DataStructuresAndAlgorithmsInCSharp.Algorithms;
using DataStructuresAndAlgorithmsInCSharp.DataStructures;

namespace DataStructuresAndAlgorithmsInCSharp.Tests.DataStructures;

public class AlgorithmsRunner
{
    public static void Run()
    {
        BubbleSortTests();
    }

    private static void BubbleSortTests()
    {
        var arr = new int[] { 5, 4, 3, 2, 1 };
        BubbleSort.SortAscending(arr);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

        BubbleSort.SortDescending(arr);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
