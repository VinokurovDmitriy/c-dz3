int a = 14212;
int b = 23432;
int c = 12821;

int getRank(int position, int num)
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
    int num1 = getRank(1, num);
    int num2 = getRank(2, num);
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    Console.Write($"Число {num} ");
    if (num1 != num5 || num2 != num4)
    {
        Console.Write("не ");
    }
    Console.WriteLine("является полиндромом");
}

checkPolindrom(a);
checkPolindrom(b);
checkPolindrom(c);