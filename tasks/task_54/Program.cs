// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
   В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
// Метод запроса числа 
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
// Метод определения матрицы
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
// Метод сортировки чисел по убыванию
void SortArrangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int r = 0; r < matrix.GetLength(1) - 1; r++)
            {
                if (matrix[i, r] < matrix[i, r + 1])
                {
                    int res = matrix[i, r + 1];
                    matrix[i, r + 1] = matrix[i, r];
                    matrix[i, r] = res;
                }
            }
        }
    }
}
// Метод печати массива
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
int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");

int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
SortArrangeMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);



