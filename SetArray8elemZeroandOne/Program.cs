// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void SetArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
    int num =  new Random().Next(2);
    array[i] = num;
    }
}
void OutputOnTheSqreen(int[] array)
{
   foreach(int item in array)
   {
    Console.Write($" {item} ");
   }
}
int[] arr = new int[8];
SetArray(arr);
OutputOnTheSqreen(arr);