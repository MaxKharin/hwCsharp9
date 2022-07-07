// Задача 2: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

int row = Prompt("Rows number: ");
int column = Prompt("Columns number: ");
int min = 0;
int max = 10;
int[,] array = InitArray(row, column, min, max);
PrintArray(array);

int minSumRow = 0;
int sumRow = SumRowElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumRowElements(array, i);
    if (tempSumRow < sumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}
Console.WriteLine($"Row number {minSumRow+1} is the row with a minimum sum of the elements ({sumRow})");

int SumRowElements(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] InitArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}