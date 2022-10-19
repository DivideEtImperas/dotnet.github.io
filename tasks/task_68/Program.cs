/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
   Даны два неотрицательных числа m и n.
   m = 2, n = 3 -> A(m,n) = 9
   m = 3, n = 2 -> A(m,n) = 29
*/
Console.Clear();
int GetNumber(string message)
{
   Console.WriteLine(message);
   int number = int.Parse(Console.ReadLine()?? "");
   return number;
}
// Метод подсчета функции Аккермана
int AckermanFunction(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
  
    if ((m != 0) && (n == 0))
      return AckermanFunction(m - 1, 1);
    else
      return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");

Console.WriteLine($"m = {m}, n = {n} -> " + AckermanFunction(m, n));