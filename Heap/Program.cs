var heap = new Heap.MinIntegerHeap();

heap.Add(5);
heap.Add(4);
heap.Add(3);
heap.Add(2);
heap.Add(1);

Console.WriteLine("After inserting:");
foreach (var item in heap.GetArray())
{
    Console.Write(item + " ");
}

Console.WriteLine();

heap.RemoveRoot();

Console.WriteLine("Removed root:");
foreach (var item in heap.GetArray())
{
    Console.Write(item + " ");
}
