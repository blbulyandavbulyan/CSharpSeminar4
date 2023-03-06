/*
 Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Не использовать Math.Pow() и аналоги!
*/
double myPower(int a, uint naturalPower)
{
    double result = 1;
    for(int i = 0; i < naturalPower; i++)
    {
        result *= a;
    }
    return result;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень: ");
uint p =  Convert.ToUInt32(Console.ReadLine());
Console.WriteLine(myPower(a, p));