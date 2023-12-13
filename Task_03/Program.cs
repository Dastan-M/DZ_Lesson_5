// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindRowWithMinSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    int minSum = int.MaxValue;
    int minSumRowIndex = -1;

    for (int i = 0; i < rows; i++)
    {
        int currentSum = 0;

        for (int j = 0; j < columns; j++)
        {
            currentSum += array[i, j];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRowIndex = i;
        }
    }

    return minSumRowIndex;
}
int rowWithMinSum = FindRowWithMinSum(twoDimArray);
Console.WriteLine($"строка с наименьшей суммой элементов: {rowWithMinSum}");