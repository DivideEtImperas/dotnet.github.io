/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/
/*
1. Создали функцию ввода числа с возвращаемым значением
2. Надо получить два числа из пункта 1
3. Привести два числа к модульному значению
4. Надо найти минимальное число и поделить максимальное из этих чисел на минимальное
5. Если результат от деления равен минимальному числу то число кратно
6. 
 

*/
int GetNumber ()
{
Console.WriteLine("Введите число");
string numberStr = Console.ReadLine()??"";
int number = int.Parse(numberStr);
return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();
firstNumber = Math.Abs(firstNumber);
secondNumber = Math.Abs(secondNumber);

if (firstNumber >secondNumber)
{
    if (firstNumber / secondNumber == secondNumber) 
    {
      Console.WriteLine("да");
    }
    else 
    {
        Console.WriteLine("нет");
    }
}
else if(secondNumber>firstNumber) 
{
    if (secondNumber / firstNumber == secondNumber) 
      {
      Console.WriteLine("да");
    }
    else 
    {
        Console.WriteLine("нет");
    }
}


