// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

int[,] DelRowColumnArr(int[,] matrix)
{
    int[,] resultArr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int min = matrix[0, 0];
    int indexColumnMin = 0;
    int indexRowMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRowMin = i;
                indexColumnMin = j;
            }
        }
    }
    Console.WriteLine($"min = {min} indexRowMin = {indexRowMin}  indexColumnMin = {indexColumnMin}");
    int countI = 0;
    int countJ = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == indexRowMin)
        {
            // countI++;
            continue;
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j == indexColumnMin)
            {
                // countJ++;
                continue;
            }
            resultArr[countI, countJ] = matrix[i, j];
            countJ++;
        }
        countJ = 0;
        countI++;
    }


    return resultArr;
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine("Матрица:");
int[,] arr = DelRowColumnArr(matrix);
PrintMatrix(arr);

