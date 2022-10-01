// Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;

Clear();
Write("Введите число для возыедения в степень: ");
int A = int.Parse(ReadLine()!);
if (A == 0)
    {
        WriteLine("Некорректное число.");
        return;
    }
Write("Введите степень числа: ");
int B = int.Parse(ReadLine()!);
WriteLine($"{A} в {B} степень равняется {Stepen(A, B)}");
WriteLine($"{A} в {B} степень равняется {Stepen2(A, B)}");


// Возведение числа А в степень В
double Stepen (int numA, int numB)
{
    double result = 0;
    result = Math.Pow(numA, numB);
    
    return result;
}

// Возведение числа А в степень В
int Stepen2 (int numA, int numB)
{
    int result = 1;
    while (numB != 0)
    {
        result = result * numA;
        numB--;
    } 
    return result;   
}