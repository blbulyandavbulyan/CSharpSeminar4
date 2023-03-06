// See https://aka.ms/new-console-template for more information
int getInt(String msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int getSummFromTo(int start, int end)
{
    int result = 0;
    for(int i = start; i <= end; i++)
    {
        result += i;
    }
    return result;
}
int a = getInt("Введите чилсо: ");
Console.WriteLine(getSummFromTo(1, a));