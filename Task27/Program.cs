// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
if (number == 0)
{
    WriteLine("Введите другое число.");
    return;
}
if (number < 0)
{
    number = Math.Abs(number);
}
WriteLine($"Сумма цифр числа {number} равна {Sum(number)}");




int Sum(int num)
{
    int result = 0;
    while (num != 0)
    {
        result = result + num%10;
        num /= 10;
    }
    return result;
}


