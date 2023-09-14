using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CustomList<T>
{
    private T[] items;
    private int count;

    public CustomList(int capacity)
    {
        items = new T[capacity];
        count = 0;
    }

    public int Count
    {
        get { return count; }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[count] = item;
        count++;
    }
}

class Program
{
    static void Main()
    {
        CustomList<int> myList = new CustomList<int>(3);
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        Console.WriteLine("Element at index 0: " + myList[0]);
        Console.WriteLine("Element at index 1: " + myList[1]);
        Console.WriteLine("Element at index 2: " + myList[2]);

        myList[1] = 25;

        Console.WriteLine("Modified element at index 1: " + myList[1]);

        Console.ReadLine();
    }
}
