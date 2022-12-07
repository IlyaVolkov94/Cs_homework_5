// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillRandomArray(int Arg)  //Создает произвольно заполненный массив
{
    int[] Array = new int[Arg];
    for (int i = 0; i < Arg; i++)
    {
        Array[i] = new Random().Next(100, 1000);
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
    return Array;
}

int CountEven(int[] Array)  //Посчитывает количество четных чисел
{
    int Count = 0;
    foreach (int Buf in Array)
    {
        if (Buf % 2 == 0) Count++;
    }
    return Count;
}

try
{
    Console.WriteLine("Введите размер массива");
    int Size = Convert.ToInt32(Console.ReadLine());
    int[] Array = new int[Size];
    Array = FillRandomArray(Size);
    int Result = CountEven(Array);
    Console.WriteLine("Количество четных чисел в массиве: " + Result);
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}