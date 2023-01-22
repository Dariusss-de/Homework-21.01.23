// Подсчитать сумму цифр в числе
int SumNumber(int arg)
{
    int res = 0;
    int sum=0;
    while(arg>0)
    {
        res = res+ arg%10;
        arg = arg/10;

    }
    Console.WriteLine("Сумма цифр = "+res);
    return res;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
SumNumber(number);
