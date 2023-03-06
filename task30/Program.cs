/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
int[] randomFillArray(int arraySize)
{
    int[] arr = new int[arraySize];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Random.Shared.Next(0, 2);
    }
    return arr;
}
int []arr = randomFillArray(8);

for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}