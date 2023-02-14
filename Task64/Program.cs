//Задача 64: Задайте значение N. Напишите программу, которая .
//выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

Console.Clear();
Console.Write("введите значение числа  N =  ");
int N = int.Parse(Console.ReadLine()!);
string PrintArray(int N)
{
    if (N == 1) return "1";
    else
    {
        return PrintArray(N - 1) + " , " + N.ToString();
    }
}
Console.Write(PrintArray(N));
