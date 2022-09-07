// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int numbersNatur (int M, int N)
{
    if ( M == N) return N;
    return M + numbersNatur(M+1, N);
}

Console.WriteLine("Введите первое число ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = numbersNatur (M, N);
Console.WriteLine($"Сумма равна = {sum}");
