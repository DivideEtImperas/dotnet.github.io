//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

/*
  0_1_2_3
0|1|2|8|7
1|4|5|4|5

1 4
2 5
8 7
7 5


*/
int[,] ReplaceRowsOnColumns(int[,] matrix)
{
    int[,] matrixReplaced = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrixReplaced.GetLength(0); i++)
    {
        for (int j = 0; j < matrixReplaced.GetLength(1); j++)
        {
            matrixReplaced[i,j]= matrix[j,i];           
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
int [,] matrixReplaced = ReplaceRowsOnColumns(matrix);
PrintMatrix(matrixReplaced);
