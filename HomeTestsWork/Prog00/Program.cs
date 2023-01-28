static int[] CreateArray()
{
  return new int[10];
}
void Fill(int[]elements)

{
int length = elements.Length;
int index = 0;

while (index < length)
{
  int current = Random.Shared.Next(30);
  elements[index] = current;
  
  index = index + 1;
}
}

int GetSum(int[] array)
{
  int size = array.Length;
  int sum = 0;

  int position = 0;

  while(position < size)
  {
    int current = array[position];
    if(current >= 10 && current <= 99)
    {
      sum = sum + current;
    }
  }
  return sum;
}

string Print(int[] collection)
{
  string output = String.Empty;

  int size = collection.Length;
  int index = 0;
  while(index < size)
  {
    int current = collection[index];
    output = output + $"{current}";
  }
  return output;
}

int[] arr = CreateArray();
Fill(arr);    

