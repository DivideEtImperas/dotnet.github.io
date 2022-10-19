/* Задайте значения M и N. Напишите программу, которая найдёт 
   сумму натуральных элементов в промежутке от M до N.

   M = 1; N = 15 -> 120
   M = 4; N = 8. -> 30
*/
Console.Clear();
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
// Метод подсчета всех элементов в промежутке от M до N
int SumNaturalElements(int m, int n)
{
    int sum = 0;
    sum = ((m + n) * (n - m + 1)) / 2;
    return sum;
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
Console.WriteLine("Сумма чисел в промежутке от m до n: " + SumNaturalElements(m, n));
