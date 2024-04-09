internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the rows: ");
        int rows = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the cols: ");
        int cols = Int32.Parse(Console.ReadLine());

        double[,] matrix = new double[rows, cols];

        // Fill the matrix with user input
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Enter element at row {i + 1} - col {j + 1}: ");
                matrix[i, j] = Int32.Parse(Console.ReadLine());
            }
        }

        // Find the maximum element in the matrix
        double maxElement = matrix[0, 0];
        int maxRow = 0;
        int maxCol = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    maxRow = i + 1;
                    maxCol = j + 1;
                }
            }
        }

        // Display the result
        Console.WriteLine($"The maximum element in the matrix is {maxElement} at row {maxRow}, col {maxCol}.");
    }
}