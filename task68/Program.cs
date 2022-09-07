﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int M, int N)
{
    if (M == 0) return N + 1;
    else if (M > 0 && N == 0) return Ackermann(M - 1, 1);
    return Ackermann(M-1, Ackermann(M, N-1));
}

int M = 2;
int N = 3;
int result = Ackermann(M, N);
Console.WriteLine($"Значение Акермана = {result}");