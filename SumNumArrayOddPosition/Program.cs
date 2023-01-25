// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void SetArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
    int num =  new Random().Next(1,10);
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

int SumOddNum(int[] array)
{
    int result = 0;
    
    for(int i = 0;i<array.Length;i++)
    {
        if(array[i]%2 != 0) result = result + array[i];
    }
        return result;
    
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
SetArray(arr);
OutputOnTheSqreen(arr);
Console.WriteLine($"Сумма нечётных чисел = {SumOddNum(arr)}");