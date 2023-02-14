//Задача 68: Напишите программу вычисления функции Аккермана с 
//помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("введите два неотрицательных числа");
int A = InputNumbers("Первое число A= ");
int B = InputNumbers("Второе число B= ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Akkerman(int A, int B)
{
    if (A == 0) return B + 1;
    else if (A != 0 && B == 0) return Akkerman(A - 1, 1);
    else return (Akkerman(A - 1, Akkerman(A, B - 1)));
}
Console.WriteLine($"Функция Аккермана для чисел ({A},{B}) = {Akkerman(A, B)}");
