/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine("Введите число a;");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число b;");
int b = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число c;");
int c = int.Parse(Console.ReadLine() ?? "");
Random rnd = new Random();
int[,,] matrix = new int[a, b, c];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int l = 0; l < matrix.GetLength(2); l++)
        {
            matrix[i, j, l] = rnd.Next(100);
        }
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{


    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        for (int l = 0; l < matrix.GetLength(2); l++)
        {
            Console.Write($"{matrix[i, j, l],1}({i},{j},{l}) ");
        }
        Console.WriteLine();
    }
}