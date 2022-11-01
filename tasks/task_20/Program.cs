//Напишите программу, которая по заданному номеру четверти, показывает 
//диапазон возможных координат точек в этой четверти (x и y).



int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string QuaterTest(int quater,int coord)
{
    if (quater==1)
    {
        return "x>0y>0";
    }
    if (quater==2)
    {
        return "x>0y>0";
    }
     if (quater==3)
    {
        return "x>0y>0";
    }
    if (quater==4)
    {
        return "x>0y>0";
    }
    return "такой четверти нет";
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}


int coordX = ReadData("Введите координату X не равную 0: ");
int coordY = ReadData("Введите координату Y не равную 0: ");

string quaterAnswer = QuaterTest(coordX, coordY);

PrintData("Номер четверти: ", quaterAnswer.ToString());