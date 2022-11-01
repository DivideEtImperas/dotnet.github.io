//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
void RecursionNum(int m,int n)
{

    if (m > n)
        return;

    RecursionNum(m,n - 1);
    Console.Write(n + ", ");

}
int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");

RecursionNum(m,n);