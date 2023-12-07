// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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
System.Console.WriteLine("двумерный массив: ");
Print(twoDimArray);

SwapFirstAndLastRows(twoDimArray);

Console.WriteLine("после замены первой и последней строк:");

Print(twoDimArray);

static void SwapFirstAndLastRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int j = 0; j < columns; j++)
    {
        int temp = array[0, j];
        array[0, j] = array[rows - 1, j];
        array[rows - 1, j] = temp;
    }
}

