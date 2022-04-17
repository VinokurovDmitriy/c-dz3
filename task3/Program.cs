// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = new Random().Next(1, 20);
int i = 1;
Console.Write($"{num}-> ");
while(i <= num){
    Console.Write($"{i * i * i}");
    if(i < num){
        Console.Write(", ");
    } else {
         Console.WriteLine(".");
    }
    i++;
}