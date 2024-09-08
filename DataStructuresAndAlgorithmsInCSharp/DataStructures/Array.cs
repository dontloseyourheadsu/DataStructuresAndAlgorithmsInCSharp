using System.Collections;

namespace DataStructuresAndAlgorithmsInCSharp.DataStructures;

public class Array<T> : IEnumerable<T>
{
    private T[] arr;

    public T this[int index]
    {
        get => arr[index];
        set => arr[index] = value;
    }

    public int Length => arr.Length;

    public Array(int size)
    {
        arr = new T[size];
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in arr)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
