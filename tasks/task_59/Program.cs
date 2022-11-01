// Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] ReplaceStrings(int[,] matrix)
{
    int[,] matrixReplaced = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                matrixReplaced[i, j] = matrix[matrix.GetLength(0) - 1, j];
            }
            else if (i == (matrix.GetLength(0) - 1))
            {
                matrixReplaced[i, j] = matrix[0, j];
            }
            else
            {
                matrixReplaced[i, j] = matrix[i, j];
            }
        }
    }
    return matrixReplaced;
}

int n = GetNumber("Введите число m");
int m = GetNumber("Введите число n");
int[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine();
int [,] matrixReplaced = ReplaceStrings(matrix);
PrintMatrix(matrixReplaced);
