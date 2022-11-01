/*Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
*/
//Решение через Dictionary
int [,] InitMatrix(int n, int m)
{
    int[,] resultMatrix = new int[n, m];
    Random rnd = new Random();
    for(int i =0 ; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = rnd.Next(1,9);
        }
    }
    return resultMatrix;
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

int[,] matrix = InitMatrix(3,4);
PrintMatrix(matrix);

Dictionary<int, int> resultDic = new Dictionary<int, int>();

//у словаря может быть только один уникальный ключ
// ключ = 1, значение = 5
// ключ = 1, значение = 6 

//var r = [1, 2 ,3 ,4 ,5 ,6 ,777]
//r.Contains(7);
foreach(var item in matrix)
{
    if(resultDic.Keys.Contains(item))
        resultDic[item] =  resultDic[item] + 1;
    else
        resultDic.Add(item, 1);
}

Console.WriteLine();

foreach(var item in resultDic)
    Console.WriteLine($"{item.Key} встречается {item.Value} раз");
