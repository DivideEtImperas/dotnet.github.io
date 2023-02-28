//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.WriteLine("Введите число:");
string number = (Console.ReadLine()??"");
int count = 0;
for (int i = 0; i < number.Length; i++)
{
    if (int.TryParse(number[i].ToString(), out int result))
        count++;
}
Console.WriteLine(count);





