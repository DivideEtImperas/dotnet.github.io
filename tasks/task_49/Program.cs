//Напишите программу, которая будет создавать копию заданного 
//массива с помощью поэлементного копирования.


int GetNumber()
{
    Console.WriteLine("Введите десятичное число");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int[] InitArray(int number)
{
    int[] array = new int[number];
    Random rnd = new Random();
    for (int i = 0; i < number; i++)
    {
        array[i]=rnd.Next(0,10);
        Console.Write(array[i]+" ");
    }
    return array;
}
void GetArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
        Console.Write(newArray[i]+" ");
    }
}
int number = GetNumber();
int[] array = InitArray(number);
Console.WriteLine();
GetArray(array);
