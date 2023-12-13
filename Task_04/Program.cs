// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку 
// и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

int[,] FillTwoDimArray(int rows, int cols)
{
    int[,] twoDimArray = new int[rows, cols];
    Random rand = new();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            twoDimArray[i, j] = rand.Next(1, 10);
        }
    }
    return twoDimArray;
}
void Print(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] twoDimArray = FillTwoDimArray(4, 4);
Print(twoDimArray);

        int row = 0, column = 0;
        FindRowColumnWithMinElement(twoDimArray, out row, out column);

        int[,] newArray = RemoveRowAndColumn(twoDimArray, row, column);

        Console.WriteLine("\nArray after removing row and column with the smallest element:");

        PrintArray(newArray);

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void FindRowColumnWithMinElement(int[,] array, out int row, out int column)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int minElement = array[0, 0];
        row = 0;
        column = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    row = i;
                    column = j;
                }
            }
        }
    }

    static int[,] RemoveRowAndColumn(int[,] array, int rowToRemove, int columnToRemove)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int[,] newArray = new int[rows - 1, columns - 1];

        int newRow = 0, newColumn = 0;

        for (int i = 0; i < rows; i++)
        {
            if (i == rowToRemove)
                continue;

            newColumn = 0;

            for (int j = 0; j < columns; j++)
            {
                if (j != columnToRemove)
                {
                    newArray[newRow, newColumn] = array[i, j];
                    newColumn++;
                }
            }

            newRow++;
        }

        return newArray;
    }