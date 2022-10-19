//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

//ввод элеменетов через консоль (через запятую. использовать метод string.Split())


string[] PrintArray(string arrayStr) //Метод с аргументом
{
    string[] array = arrayStr.Split(", "); //Передает Метод Split строке 
    return array; // Возвращает массив 
}
Console.WriteLine("Ввод массива:");

string arrayStr = Console.ReadLine()??""; //Считывает массив  из консоли
int arrayLength = arrayStr.Length; //Объявление и инициализация целочисленной переменной размером массива
string [] array = PrintArray(arrayStr);// Способ печати массива
for(var i =0; i<array.Length;i++) //Цикл индекса
{
    //Выво на консоль
    Console.WriteLine("Вывод массива:"); 
    Console.Write($"{array[i]}");
}