internal class Program
{
    private static void Main(string[] args)
    {
        //B1
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
        for (int i=0; i < array.Length; i++)
        {
            Console.WriteLine("Enter element" + (i + 1) + " : ");
            array[i] = Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("Array: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.WriteLine(array[j] + "\t");
        }

        //B2
        Console.WriteLine("Enter X to insert: ");
        int X = Int32.Parse(Console.ReadLine());

        //B3 & B4
        int index;
        do
        {
            Console.WriteLine("Enter a insert index:");
            index = Int32.Parse(Console.ReadLine());
            if (index <= 1 || index >= array.Length - 1)
                Console.WriteLine($"Index should be bigger than 0 and smaller than {array.Length-1}");
        } while (index <= 1 || index >= array.Length - 1);

        //B5
        int[] newArray = new int[array.Length + 1];
        bool inserted = false;
        for (int i=0; i < newArray.Length; i++)
        {
            if (!inserted)
            {
                if (i == index)
                {
                    newArray[i] = X;
                    inserted = true;
                }
                else
                {
                    newArray[i] = array[i];
                }
            }
            else
            {
                newArray[i] = array[i-1];
            }
        }

        Console.WriteLine("\nNew Array: ");
        for (int j = 0; j < newArray.Length; j++)
        {
            Console.WriteLine(newArray[j] + "\t");
        }
    }
}