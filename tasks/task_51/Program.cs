/*
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/


//получает число с консоли
int GetNumber(string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine()??"");
  return number;
}

int [,] InitMatrix(int m, int n)
{
  int[,] matrix = new int[m, n];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
         matrix[i,j] = rnd.Next(1, 10);
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
          Console.Write($"{matrix[i,j]} ");
      }
      Console.WriteLine();
   }
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
