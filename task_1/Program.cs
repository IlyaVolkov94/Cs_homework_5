// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillRandomArray(int arg)
{
    int[] Array = new int[arg];
    for (int i = 0; i < arg; i++)
    {
        Array[i] = new Random().Next(100, 1000);
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
    return Array;
}

int CountEven(int[] array)
{
    int numCount = 0;
    foreach (int Buf in array)
    {
        if (Buf % 2 == 0) numCount++;
    }
    return numCount;
}

try
{
    Console.WriteLine("Введите размер массива");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[arraySize];
    array = FillRandomArray(arraySize);
    int result = CountEven(array);
    Console.WriteLine("Количество четных чисел в массиве: " + result);
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}