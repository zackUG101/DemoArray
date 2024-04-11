internal class Program
{
    public static void Main(string[] args)
    {
        int[] array = GenArray();

        int indexToRemove;
        do
        {
            Console.WriteLine("Enter a insert index:");
            indexToRemove = Int32.Parse(Console.ReadLine());
            if (indexToRemove <= 0 || indexToRemove >= array.Length - 1)
                Console.WriteLine($"Index should be >= 0 and <= {array.Length - 1}");
        } while (indexToRemove <= 0 || indexToRemove >= array.Length - 1); ;

        Console.WriteLine("Original array:");
        PrintArray(array);

        array = RemoveElementAtIndex(array, indexToRemove);

        Console.WriteLine("\nArray after removing element at index " + indexToRemove + ":");
        PrintArray(array);
    }

    public static int[] GenArray()
    {
        int size;
        int[] array;
        do
        {
            Console.WriteLine("Enter a size:");
            size = Int32.Parse(Console.ReadLine());
            if (size > 20)
                Console.WriteLine("Size should not exceed 20");
        } while (size > 20);

        array = new int[size];
        int i = 0;
        while (i < array.Length)
        {
            Console.WriteLine("Enter element" + (i + 1) + " : ");
            array[i] = Int32.Parse(Console.ReadLine());
            i++;
        }
        return array;
    }

    public static int[] RemoveElementAtIndex(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }

        int[] newArray = new int[array.Length - 1];

        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i != index)
            {
                newArray[j++] = array[i];
            }
        }

        return newArray;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}