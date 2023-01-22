// Найти сумму чисел от 1 до А
int sumNumber(int arg)
{
    int result=0;
for(int i=1;i<=arg;i++)
{
   result = result+i;
   Console.WriteLine("Cумма чисел: "+result);
}
return result;
}
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
sumNumber(A);
