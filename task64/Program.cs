// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintNumber (int numM, int numN)
{
    if (numM > numN) return;
    Console.Write($"{numM} ");
    PrintNumber(numM+1, numN);
}

Console.WriteLine("Введите первое целое число ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число ");
int numberM = Convert.ToInt32(Console.ReadLine());
PrintNumber(numberN, numberM);