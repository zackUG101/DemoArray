internal class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the square matrix: ");
        int size = int.Parse(Console.ReadLine());
        double[,] matrix = new double[size, size];

        Console.WriteLine("Enter the elements of the square matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double sum = CalculateDiagonalSum(matrix);
        Console.WriteLine($"The sum of the elements on the main diagonal is: {sum}");
    }

    static double CalculateDiagonalSum(double[,] matrix)
    {
        double sum = 0;
        int size = matrix.GetLength(0); // Assuming matrix is square
        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, i];
        }
        return sum;
    }
}
