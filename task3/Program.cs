﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = new Random().Next(-10, 10);
int number = 1;
int end = num;
Console.Write($"{num}-> ");
if (num < 0)
{
    number = num;
    end = -num;
}
while (number <= end)
{
    Console.Write(number * number * number);
    if (number < end)
    {
        Console.Write(", ");
    }
    else
    {
        Console.WriteLine(".");
    }
    number++;
}