/*//Вид 1 (Ничего не принимают, ничего не возвращают)
void Method1()
{
    Consoole.WriteLine("Автор...");
}
//Method1();



//Вид 2 (Что-то принимают, ничего не возвращают)
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)//пока i меньше count 
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg:"Текст",count:4);//"то что в кавычках вывод сообщения", count:4 - указывает сколько раз вывести сообщение
Method21(count: 4, msg: "новый текст");// Второй вариант исполнения предыдущей строки (можно в разном порядке писать)


//Вид 3 (Ничего не принемают, что-то возвращают)
int Method3()// Пустые скобки, Method3 ничего не принемает
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4 (Что-то принимают, что-то возвращают)
string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)

    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "a");
//Console.WriteLine(res);


//Вывод таблицы умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/
//======Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточкми,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

/*string text = "- Я думаю, сказал князь, улыбаясь, - что "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
//string s = "qwerty
//            012
//s[3]// r 
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'k', 'K');
Console.WriteLine(newText);*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length -1; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);