//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10


int GetNumber()
{
    Console.WriteLine("Введите десятичное число");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string ConvertIntoBinary(int number)
{
    if (number == 0)
        return "0";
    int leftover = number % 2;
    string leftoverStr = string.Empty;
    while (number >= 1)
    {
        leftover = number % 2;
        number = number / 2;
        leftoverStr += leftover.ToString(); //можно применить string binary= Convert.ToString(Value, 2) ?


    }
    return ReverseString(leftoverStr);
}

string ReverseString(string str)
{
    char[] array = str.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}
int number = GetNumber();
string binaryNumber = ConvertIntoBinary(number);
Console.WriteLine(binaryNumber);