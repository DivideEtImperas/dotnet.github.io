//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine("Введите числа:");
int numberA = int.Parse(Console.ReadLine());// Преобразует строковое значение в целочисленное значение
int numberB = int.Parse(Console.ReadLine());// Преобразует строковое значение в целочисленное значение


{
   Console.Write("Натуральная степень числа А:");
   Console.Write(Math.Pow(numberA,numberB));
}

