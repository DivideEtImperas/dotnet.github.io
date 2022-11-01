/*Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int RecursionNum(int n, int sum)
{

    if (n == 0)
        return sum;
    sum += n % 10;
    return RecursionNum(n / 10, sum);

}
int n = GetNumber("Введите число:");
int sum = 0;
Console.WriteLine(RecursionNum(n, sum));