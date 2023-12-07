// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

System.Console.Write("Enter i from 1 till 3: ");
int i = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter j from 1 till 3: ");
int j = Convert.ToInt32(System.Console.ReadLine());

int rows = twoDimArray.GetLength(0);
int cols = twoDimArray.GetLength(1);
if (i >= 0 && i < rows && j >= 0 && j < cols)
{
    int num = twoDimArray[i, j];
    System.Console.WriteLine($"значение этого элемента: {num}");
}
else
{
    System.Console.WriteLine("такого элемента нет");
}