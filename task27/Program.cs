/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
int getSummOfDigits(int n)
{
    int result = 0;

    for(int i = Math.Abs(n); i > 1; i /= 10)
    {
        result += (i % 10);
    }
    return result;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(getSummOfDigits(number));