class MineSweeper
{
    static void Main()
    {
        string[,] map = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };

        int mapHeight = map.GetLength(0);
        int mapWidth = map.GetLength(1);
        string[,] mapReport = new string[mapHeight, mapWidth];

        // Fill the report based on mine proximity
        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                if (map[y, x] == "*")
                {
                    mapReport[y, x] = "*";
                }
                else
                {
                    mapReport[y, x] = CountMines(map, y, x).ToString();
                }
            }
        }

        // Print the final map report
        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                Console.Write(mapReport[y, x]);
            }
            Console.WriteLine();
        }
    }

    static int CountMines(string[,] map, int row, int col)
    {
        int mineCount = 0;
        int[] rowOffsets = { -1, -1, -1, 0, 1, 1, 1, 0 };
        int[] colOffsets = { -1, 0, 1, 1, 1, 0, -1, -1 };

        for (int i = 0; i < 8; i++)
        {
            int newRow = row + rowOffsets[i];
            int newCol = col + colOffsets[i];

            if (newRow >= 0 && newRow < map.GetLength(0) && newCol >= 0 && newCol < map.GetLength(1))
            {
                if (map[newRow, newCol] == "*")
                {
                    mineCount++;
                }
            }
        }
        return mineCount;
    }
}
