namespace Heap;

public interface IHeap<T>
{
    void Add(T item);

    T[] GetArray();

    void RemoveRoot();
}