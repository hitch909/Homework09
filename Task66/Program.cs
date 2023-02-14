//Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.Write("Введите значение числа M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение числа N = ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();

static int Summ(int M, int N)
{
    if (M == N) return N;
    else return M + Summ(M + 1, N);
}
Console.WriteLine($"Сумма чисел в промежутке от {M} до {N} = {Summ(M, N)}");
