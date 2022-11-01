//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да


int [] InitArray(int demension)
{
int[] arr = new int[demension];

Random rnd = new Random();

for (int i = 0; i < demension; i++)
{
    arr[i] = rnd.Next(-9,10);
}

return arr;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

//ввести число
Console.WriteLine("Введиите чило: ");
int num = int.Parse(Console.ReadLine() ?? "");

//получить массив

int [] array = InitArray(5);
PrintArray(array);
bool existNum = false;

//проверять числа массива до тех пор пока не будет сопадения
for (int i = 0; i < array.Length; i++)
{
    if (num == array[i])
    {
        existNum = true;
        break;
    }
}

if (existNum != true)
Console.WriteLine("Число не содержится в массиве");

else Console.WriteLine($"Число {num} есть в массиве");
