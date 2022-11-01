//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


Random rnd = new Random();
int[] arr = new int[6];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(2, 10);
}
var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");
for (int i = 0; i < arr.Length/2; i++)
{
    Console.Write(arr[i]*arr[arr.Length-i-1] + " ");
}
if (arr.Length%2!=0)
{
    Console.Write(arr[arr.Length/2]);
}