// Определить, присутствует ли в заданном массиве, некоторое число
void SetArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
    int num =  new Random().Next(1,20);
    array[i] = num;
    }
}
void OutputOnTheSqreen(int[] array)
{
   foreach(int item in array)
   {
   Console.Write($" {item} ");
   }
   Console.WriteLine();
}

void FindNumberinArray(int[] array, int arg)
{
    int num = 0 ;
   for(int i=0;i<array.Length;i++)
   {
    num = array[i];
   }
    if(num == arg)  Console.WriteLine($"Введённое число {arg} присутствует в массиве");
    else Console.WriteLine($"Введённое число {arg} отсутствует в массиве");
   
}
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
SetArray(arr);
OutputOnTheSqreen(arr);
FindNumberinArray(arr, number);