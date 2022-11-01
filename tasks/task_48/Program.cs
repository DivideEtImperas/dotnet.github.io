//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8



Console.WriteLine("До какого числа считать ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());
int first = 0;
Console.Write("{0} ", first);
int second = 1;
Console.Write("{0} ", second);
int sum = 0;
while (number>=sum)
{
    sum = first + second;

    Console.Write("{0} ", sum);

    first = second;
    second = sum;
    
}


//Решение с помощью массива
/*
int GetNumber()
{
    Console.WriteLine("Введите число");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void Fibonacci(int number)
{
    long[] fib = new long[number];
    fib[0] = 0;
    fib[1] = 1;
    Console.Write($"{fib[0]} {fib[1]} ");
    int i = 2;
    while (i<=number-1)
    {
        fib[i] = fib[i-2] + fib[i-1];
        
        Console.Write($"{fib[i]} ");
        i++;
    }
}
int num = GetNumber();
Fibonacci(num);

*/