//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


int FindRandomInt(int min, int max)
{
    return new Random().Next(min, max);
}
int[] Create(int size)
{
    return new int[size];
}
void Fill(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = array[i] + new Random().Next(1, 99);
    }
}
Console.Clear();
int size = FindRandomInt(4, 12);
int[] collection = Create(size);
Fill(collection);
Console.WriteLine($"Задан массив из случайных чисел: " + "{" + (String.Join(' ', collection)) + "}");
Console.WriteLine("Максимальное число " + collection.Min());
Console.WriteLine("Минимальное число " + collection.Max());
int differece = collection.Max() - collection.Min();
Console.WriteLine("Разница между максимальным и минимальным: " + differece);