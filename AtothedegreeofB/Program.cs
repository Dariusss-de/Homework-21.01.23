// Возведите число А в натуральную степень B используя цикл
int aDegreeeB(int arg1, int arg2)
{
    int result=0;
for(int i =0;i<=arg2;i++)
{
   result = (int)Math.Pow(arg1,i);
   Console.WriteLine("Значение числа: "+result);
}
return result;
}
Console.Write("Введите число A: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите значение степени: ");
int degree = int.Parse(Console.ReadLine());
aDegreeeB(number,degree);