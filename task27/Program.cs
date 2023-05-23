// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfNumb(int num1)
{
    int sum = 0;
    while (num1 > 0)
    {
        sum = sum + num1 % 10;
        num1 = num1 / 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int sum = SumOfNumb(num1);
Console.WriteLine($"Сумма цифр в числе = {sum}");