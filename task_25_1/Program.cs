// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int numberA, int numberB)
{
    int number = 1;
    for(int i = 0; i < numberB; i++)
    {
         number *= numberA;
    }
    return number;
}

bool VE(int numberB)
{
    if (numberB < 0)
    {
        System.Console.WriteLine("Число В не должно быть меньше нуля");
        return false;
    }
    return true;
}

int numberA = Prompt("Введите число A: ");
int numberB = Prompt("Введите число B: ");
if (VE(numberB))
{
    System.Console.WriteLine($"Число {numberA} в степени {numberB} равно {Power(numberA, numberB)}");
}
