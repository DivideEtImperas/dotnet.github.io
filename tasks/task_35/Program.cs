//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


//метод инициализации массива
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

//метод, который печатает массив на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод, который получает сумму положительных
int GetSummOfPositiveElements(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            summ += array[i]; // summ = summ + array[i];
    }
    return summ;
}

//метод, который получает сумму отрицательных
int GetSummOfNegativeElements(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            summ += array[i]; // summ = summ + array[i];
    }
    return summ;
}
//метод, который получает сумму положительных и отрицательных элементов
//первый возвращаемый элемент - сумма положительных
//второй возвращаемый элемент - сумма отрицательных
(int, int) GetSumms(int[] array)
{
    int negativeSumm = 0;
    int positiveSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            positiveSumm += array[i];
        else if(array[i] < 0)
            negativeSumm += array[i];
    }

    return (positiveSumm, negativeSumm);
}

int [] arr = InitArray(12);
PrintArray(arr);

int positiveSumm = GetSummOfPositiveElements(arr);
int negativeSumm = GetSummOfNegativeElements(arr);

Console.WriteLine($"Сумма положительных = {positiveSumm}, Сумма отрицательных = {negativeSumm}");

(int pos, int neg) = GetSumms(arr);

Console.WriteLine($"Сумма положительных = {pos}, Сумма отрицательных = {neg}");
