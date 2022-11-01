// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// задаем рандомный массив со значениями от -9 до 9
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
//реверс ранее заданного массива
int [] NewArray(int[] array)
{
    int[] resultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resultArray[i] = -array[i];
    }
    return resultArray;
}

//вывод массив на экран в строчку через пробел
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");  
    }
}

int[] array = InitArray(4);
PrintArray(array);
Console.WriteLine ();
int[] resultArray = NewArray(array);
PrintArray(resultArray);

