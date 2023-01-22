// Найти кубы чисел от 1 до N
int degreeCube(int arg)
{
    int result=0;
for(int i=1;i<=arg;i++)
{
   result = i*i*i;
   Console.WriteLine("Куб числа: "+i+" = "+result);
}
return result;
}
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
degreeCube(N);

/* Найти кубы чисел от 1 до N с генератором случайных значений
int degreeCube(int arg)
{
    int result=0;
for(int i=1;i<=arg;i++)
{
   result = i*i*i;
   Console.WriteLine("Куб числа: "+i+" = "+result);
}
return result;
}
int N = new Random().Next(1,25);
degreeCube(N);
*/
