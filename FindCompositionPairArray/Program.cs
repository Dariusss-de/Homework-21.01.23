// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
void SetArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
    int num =  new Random().Next(1,30);
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

void FindComArrNum(int[] array)
{
    int comp = 0;
     for (int i = 0; i <array.Length / 2; i++)
    {
        comp = array[i] * array[array.Length - 1 - i];
         Console.WriteLine("Результат произведения = "+comp); 
    }
 
       
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
SetArray(arr);
OutputOnTheSqreen(arr);
FindComArrNum(arr);
