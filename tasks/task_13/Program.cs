//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

if ( number > 99 && number <= 1000 )

{
    Console.WriteLine(number % 10);
}
else if (number > 999 && number < 100000) 
{
    Console.WriteLine(number / 100 % 10);
}
else 
{
    Console.WriteLine("Третьей цифры нет!");
}
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

char ThirdNumChar(string inputNumber)
{
    char[] simbols = inputNumber.ToCharArray();
    return simbols[2];
}

int ThirdNumInt(int number)
{
    int lenNum = (int)Math.Log10(number);
    int outNumber = (int)(number/Math.Pow(10,lenNum-2))%10;
    return outNumber;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}


int number = ReadData("Введите число: ");
if (number < 100)
{
    PrintData("Такой цифры нет", "");
}
else
{
    char thirdSimbol = ThirdNumChar(number.ToString());
    PrintData("Введенное вами число: ", thirdSimbol.ToString());

    int thirdSimbolInt = ThirdNumInt(number);
    PrintData("Введенное вами число: ", thirdSimbolInt.ToString());
}
