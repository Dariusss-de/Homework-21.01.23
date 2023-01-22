// Написать программу вычисления произведения чисел от 1 до N
void ProductNumber (int arg)
{
    int result=1;
    for(int i=1;i<=arg;i++)
    {
        result = result * i;
    }
     Console.WriteLine("Произведение числе = "+result);
}
Console.Write("Введите значение N: ");
int number = int.Parse(Console.ReadLine());
ProductNumber (number);

