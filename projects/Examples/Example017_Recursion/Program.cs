string path = "C:\Users\tula7\OneDrive\Рабочий стол\Examples\Example017_Recursion";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for(int i =0; i< fi.Length;i++)
{
    Console.WriteLine(fi[i].Name);
}