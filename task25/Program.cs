﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowNums(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result = result*num1;
    }
    return result;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num1} в степени {num2} = {PowNums(num1, num2)}");
