using DataStructuresAndAlgorithmsInCSharp.Algorithms;

namespace DataStructuresAndAlgorithmsInCSharpTests.Algorithms;

public class SelectionSortTests
{
    [Fact]
    public void SortAscending_SortsIntArrayAscending_WhenPassedIntArray()
    {
        // Arrange
        int[] array = [5, 3, 8, 4, 2];

        // Act
        SelectionSort.SortAscending(array);

        // Assert
        Assert.Equal([2, 3, 4, 5, 8], array);
    }

    [Fact]
    public void SortDescending_SortsIntArrayDescending_WhenPassedIntArray()
    {
        // Arrange
        int[] array = [5, 3, 8, 4, 2];

        // Act
        SelectionSort.SortDescending(array);

        // Assert
        Assert.Equal([8, 5, 4, 3, 2], array);
    }

    [Fact]
    public void SortAscending_SortsEmptyArray()
    {
        // Arrange
        int[] array = [];

        // Act
        SelectionSort.SortAscending(array);

        // Assert
        Assert.Equal([], array);
    }

    [Fact]
    public void SortDescending_SortsEmptyArray()
    {
        // Arrange
        int[] array = [];

        // Act
        SelectionSort.SortDescending(array);

        // Assert
        Assert.Equal([], array);
    }

    [Fact]
    public void SortAscending_SortsArrayWithOneElement()
    {
        // Arrange
        int[] array = [1];

        // Act
        SelectionSort.SortAscending(array);

        // Assert
        Assert.Equal([1], array);
    }

    [Fact]
    public void SortDescending_SortsArrayWithOneElement()
    {
        // Arrange
        int[] array = [1];

        // Act
        SelectionSort.SortDescending(array);

        // Assert
        Assert.Equal([1], array);
    }

    [Fact]
    public void SortAscending_SortsArrayWithDuplicateElements()
    {
        // Arrange
        int[] array = [4, 2, 2, 8, 4];

        // Act
        SelectionSort.SortAscending(array);

        // Assert
        Assert.Equal([2, 2, 4, 4, 8], array);
    }

    [Fact]
    public void SortDescending_SortsArrayWithDuplicateElements()
    {
        // Arrange
        int[] array = [4, 2, 2, 8, 4];

        // Act
        SelectionSort.SortDescending(array);

        // Assert
        Assert.Equal([8, 4, 4, 2, 2], array);
    }
}

