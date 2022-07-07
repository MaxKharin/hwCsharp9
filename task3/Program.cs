// Задача 3: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

int row1 = Prompt("First matrix rows number: ");
int column1 = Prompt("First matrix columns number: ");
int min1 = 0;
int max1 = 10;
int[,] matrix1 = InitArray(row1, column1, min1, max1);
Console.WriteLine("First Matrix: ");
PrintArray(matrix1);

int row2 = Prompt("Second matrix rows number: ");
int column2 = Prompt("Second matrix columns number: ");
int min2 = 0;
int max2 = 10;
int[,] matrix2 = InitArray(row2, column2, min2, max2);
Console.WriteLine("Second Matrix: ");
PrintArray(matrix2);

int[,] resultMatrix = new int[row1,row2];
MultiplyMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine("Multiplied matrix: ");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                temp += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = temp;
        }
    }
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