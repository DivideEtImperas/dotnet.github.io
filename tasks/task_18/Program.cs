//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int ReadData(string line)
{
    Console.WriteLine (line);
    int number = int.Parse(Console.ReadLine()?? "");
    return number;
}


string QuterTest(int quter)
{
    if (quter == 1)
    {
        return "x > 0 y > 0";
    }
    if (quter == 2)
    {
        return "x > 0 y < 0";
    }
    if (quter == 3)
    {
        return "x < 0 y < 0";
    }
    if (quter == 4)
    {
        return "x < 0 y > 0";
    }
    return "Такой четверти нет";
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

//
int quter = ReadData("Введите номер четверти: ");
//
string answer = QuterTest(quter);
//Вывожу данные
PrintData("Диапазон четверти: ", answer);
