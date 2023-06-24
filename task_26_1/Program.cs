// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

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
        i = i/10;
        colvo++;
    }
    return colvo;
}

int i = ReadInt();
int colvo1 = func(i);
Console.WriteLine($"{colvo1} цифр в числе");
