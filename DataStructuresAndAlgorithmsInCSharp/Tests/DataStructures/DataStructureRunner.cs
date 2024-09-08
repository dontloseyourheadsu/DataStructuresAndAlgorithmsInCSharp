using DataStructuresAndAlgorithmsInCSharp.DataStructures;

namespace DataStructuresAndAlgorithmsInCSharp.Tests.DataStructures;

public class DataStructureRunner
{
    public static void Run()
    {
        ArrayTests();
    }

    private static void ArrayTests()
    {
        var arr = new Array<int>(5);
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
