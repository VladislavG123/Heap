namespace Heap;

public class MinIntegerHeap : IHeap<int>
{
    /// <summary>
    /// Array of heap nodes
    /// </summary>
    private int[] _data = Array.Empty<int>();

    /// <summary>
    /// Adds item to the heap
    /// </summary>
    /// <param name="item"></param>
    public void Add(int item)
    {
        var index = _data.Length;
        _data = _data.Append(item).ToArray();

        Insert(index);
    }

    public int[] GetArray()
    {
        return _data;
    }

    /// <summary>
    /// Removes the smallest value
    /// </summary>
    public void RemoveRoot()
    {
        // Swap the first with the last node
        (_data[0], _data[^1]) = (_data[^1], _data[0]);

        _data = _data.Take(_data.Length - 1).ToArray();

        Heapify(0);
    }

    /// <summary>
    /// Inserts the value on the index to the correct position
    /// </summary>
    /// <param name="index">Node's index</param>
    private void Insert(int index)
    {
        var parentIndex = (index - 1) / 2;

        if (_data[index] >= _data[parentIndex]) return;

        // Swapping
        (_data[index], _data[parentIndex]) = (_data[parentIndex], _data[index]);

        // If next is root - close recursion
        if (parentIndex == 0) return;

        Insert(parentIndex);
    }

    /// <summary>
    /// Sort heap from ihe index position to the bottom
    /// </summary>
    /// <param name="index"></param>
    private void Heapify(int index)
    {
        var leftChildIndex = 2 * index + 1;
        var rightChildIndex = leftChildIndex + 1;

        if (leftChildIndex < _data.Length && _data[index] > _data[leftChildIndex])
        {
            (_data[index], _data[leftChildIndex]) = (_data[leftChildIndex], _data[index]);
            Heapify(leftChildIndex);
        }
        else if (rightChildIndex < _data.Length && _data[index] > _data[rightChildIndex])
        {
            (_data[index], _data[rightChildIndex]) = (_data[rightChildIndex], _data[index]);
            Heapify(rightChildIndex);
        }
    }
}