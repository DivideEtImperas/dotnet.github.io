// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void RecursionNum(int n)
{

    if (n < 1)
        return;

    RecursionNum(n - 1);
    Console.Write(n + ", ");

}
int n = GetNumber("Введите число:");
RecursionNum(n);