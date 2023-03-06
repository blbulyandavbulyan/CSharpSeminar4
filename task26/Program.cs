/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/
int a = Convert.ToInt32(Console.ReadLine());
int counter = 0;
for(int i = a; i > 0; i /= 10)
{
    counter++;
}
Console.WriteLine(counter);