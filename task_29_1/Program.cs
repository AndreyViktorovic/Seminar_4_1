// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8]; 
for (int i = 0; i < array.Length; i++)
{
    array[i] = ReadInt();
    int ReadInt()
    {
        Console.Write("Введите целое число массива ");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
        int value1 = ReadInt(); 
        int value2 = ReadInt();
        int value3 = ReadInt();
        int value4 = ReadInt();
        int value5 = ReadInt();
        int value6 = ReadInt();
        int value7 = ReadInt();
        int value8 = ReadInt();

    }
    Console.WriteLine(array[i]);
}
