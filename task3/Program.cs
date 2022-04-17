// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = new Random().Next(-10, 10);
int current = 1;
int end = num;
Console.Write($"{num}-> ");
if (num < 0)
{
    current = num;
    end = -num;
}
while (current <= end)
{
    Console.Write(current * current * current);
    if (current < end)
    {
        Console.Write(", ");
    }
    else
    {
        Console.WriteLine(".");
    }
    current++;
}