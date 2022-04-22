// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int a = 14212;
int b = 23432;
int c = 12821;

//первый способ решения с помощью функций
int getNumber(int position, int num)
{
    int i = 5;
    while (i > position)
    {
        num /= 10;
        i--;
    }
    return num % 10;
}

void checkPolindrom(int num)
{
    int num1 = getNumber(1, num);
    int num2 = getNumber(2, num);
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    Console.Write($"Число {num} ");
    if (num1 != num5 || num2 != num4)
    {
        Console.Write("не ");
    }
    Console.WriteLine("является полиндромом");
}
Console.WriteLine("Это решение с использованием функций checkPolindrom и getNumber");
checkPolindrom(a);
checkPolindrom(b);
checkPolindrom(c);
Console.WriteLine();

//второй способ решения без использования вспомогательной функции getNumber

Console.WriteLine("Это решение с использованием функций checkPolindrom2");

void checkPolindrom2(int number)
{
    Console.Write($"Число {number} ");
    if (number / 1000 != number % 10 * 10 + number / 10 % 10) Console.Write("не ");
    Console.WriteLine("палиндром");
}

checkPolindrom2(a);
checkPolindrom2(b);
checkPolindrom2(c);