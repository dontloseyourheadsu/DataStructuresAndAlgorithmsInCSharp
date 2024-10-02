using DataStructuresAndAlgorithmsInCSharp.Algorithms;

namespace DataStructuresAndAlgorithmsInCSharpTests.Algorithms;

public class SelectionSortTests
{
    [Fact]
    public void SortAscending_SortsIntArrayAscending_WhenPassedIntArray()
    {
        // Arrange
        int[] array = [5, 3, 8, 4, 2];
        var comparer = Comparer<int>.Default;

        // Act
        SelectionSort<int>.SortAscending(array, comparer);

        // Assert
        Assert.Equal([2, 3, 4, 5, 8], array);
    }

    [Fact]
    public void SortDescending_SortsIntArrayDescending_WhenPassedIntArray()
    {
        // Arrange
        int[] array = [5, 3, 8, 4, 2];
        var comparer = Comparer<int>.Default;

        // Act
        SelectionSort<int>.SortDescending(array, comparer);

        // Assert
        Assert.Equal([8, 5, 4, 3, 2], array);
    }

    [Fact]
    public void SortAscending_SortsEmptyArray()
    {
        // Arrange
        int[] array = [];
        var comparer = Comparer<int>.Default;

        // Act
        SelectionSort<int>.SortAscending(array, comparer);

        // Assert
        Assert.Equal([], array);
    }

    [Fact]
    public void SortDescending_SortsEmptyArray()
    {
        // Arrange
        int[] array = [];
        var comparer = Comparer<int>.Default;

        // Act
        SelectionSort<int>.SortDescending(array, comparer);

        // Assert
        Assert.Equal([], array);
    }

    [Fact]
    public void SortAscending_SortsArrayWithOneElement()
    {
        // Arrange
        int[] array = [1];
        var comparer = Comparer<int>.Default;

        // Act
        SelectionSort<int>.SortAscending(array, comparer);

        // Assert
        Assert.Equal([1], array);
    }

    [Fact]
    public void SortDescending_SortsArrayWithOneElement()
    {
        // Arrange
        int[] array = [1];
        var comparer = Comparer<int>.Default;

        // Act
        SelectionSort<int>.SortDescending(array, comparer);

        // Assert
        Assert.Equal([1], array);
    }

    [Fact]
    public void SortAscending_SortsArrayWithDuplicateElements()
    {
        // Arrange
        int[] array = [4, 2, 2, 8, 4];
        var comparer = Comparer<int>.Default;

        // Act
        SelectionSort<int>.SortAscending(array, comparer);

        // Assert
        Assert.Equal([2, 2, 4, 4, 8], array);
    }

    [Fact]
    public void SortDescending_SortsArrayWithDuplicateElements()
    {
        // Arrange
        int[] array = [4, 2, 2, 8, 4];
        var comparer = Comparer<int>.Default;

        // Act
        SelectionSort<int>.SortDescending(array, comparer);

        // Assert
        Assert.Equal([8, 4, 4, 2, 2], array);
    }
}


