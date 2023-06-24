// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt()
{
    Console.WriteLine("Введите целое число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int func(int i) //количество цифр
{
    int colvo = 0;
    while (i > 0)
    {
        colvo += i % 10;
        i = i / 10;
    }
    return colvo;
}

int i = ReadInt();
int colvo1 = func(i);
Console.WriteLine($"Сумма цифр в числе {colvo1}");
