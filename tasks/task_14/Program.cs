/*Напишите программу, которая будет принимать на вход два 
числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/



int GetNumber ()
{
Console.WriteLine("Введите числа");
string firstNumberStr = Console.ReadLine();
int firstNumber = int.Parse(firstNumberStr);
return firstNumber;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();
int result = firstNumber % secondNumber;
if (result == 0)
Console.WriteLine ("Кратно");
else
Console.WriteLine($"Некратно - {result}");
