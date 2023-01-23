// Показать кубы чисел, заканчивающихся на четную цифру
int CubeNumber(int arg)
{
    int result = arg*arg*arg;
    return result;
}

void FindNumber(int arg)
{
     int num = arg%10;
     Console.WriteLine ("Последняя цифра числа = "+num);
     if(num%2==0) Console.WriteLine ("Куб числа оканчивается на чётную цифру = "+arg);
     else Console.WriteLine("Куб числа оканчивается на нечётную цифру");
}


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = CubeNumber(number);
FindNumber(result);