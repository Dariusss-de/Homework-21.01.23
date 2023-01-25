// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void SetArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
    int num =  new Random().Next(100,999);
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

void OutputOnTheSqreenFrom10to99(int[] array)
{
    for(int i = 10;i>=10 && i<=99;i++)
    Console.Write(array[i]+" ");
    Console.WriteLine();
}

int FindNum(int[] array)
{
    int count=0;
    for(int i=0;i<array.Length;i++)
    {
        if(i>=10 && i<=99) count++;
    }
    return count;
}


int Num = 123;
int[] arr = new int[Num];
SetArray(arr);
OutputOnTheSqreen(arr);
OutputOnTheSqreenFrom10to99(arr);
Console.WriteLine("Количество элементов в промежутке от 10 до 99 = "+ FindNum(arr));
