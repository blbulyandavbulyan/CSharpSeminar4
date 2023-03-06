//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
void readArrayFromKeyBoard(int[] arr)
{
    Console.WriteLine($"Введите {arr.Length} чисел для массива");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int[] arr = new int[8];
readArrayFromKeyBoard(arr);
Console.WriteLine(string.Join(", ", arr));
