using DataStructuresAndAlgorithmsInCSharp.DataStructures;

namespace DataStructuresAndAlgorithmsInCSharpTests.DataStructures;

public class ArrayTests
{
    [Fact]
    public void Indexer_Get_ReturnsCorrectElement()
    {
        // Arrange
        var array = new Array<int>(5);
        array[0] = 10;
        array[1] = 20;

        // Act
        var element = array[1];

        // Assert
        Assert.Equal(20, element);
    }

    [Fact]
    public void Indexer_Set_SetsCorrectElement()
    {
        // Arrange
        var array = new Array<int>(5);

        // Act
        array[0] = 10;

        // Assert
        Assert.Equal(10, array[0]);
    }

    [Fact]
    public void Length_ReturnsCorrectLength()
    {
        // Arrange
        var array = new Array<int>(5);

        // Act
        var length = array.Length;

        // Assert
        Assert.Equal(5, length);
    }

    [Fact]
    public void GetEnumerator_ReturnsAllElements()
    {
        // Arrange
        var array = new Array<int>(3);
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;

        // Act
        var elements = new List<int>();
        foreach (var item in array)
        {
            elements.Add(item);
        }

        // Assert
        Assert.Equal(new List<int> { 1, 2, 3 }, elements);
    }

    [Fact]
    public void GetEnumerator_NonGeneric_ReturnsAllElements()
    {
        // Arrange
        var array = new Array<int>(3);
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;

        // Act
        var elements = new List<int>();
        var enumerator = ((System.Collections.IEnumerable)array).GetEnumerator();
        while (enumerator.MoveNext())
        {
            elements.Add((int)enumerator.Current);
        }

        // Assert
        Assert.Equal(new List<int> { 1, 2, 3 }, elements);
    }
}
