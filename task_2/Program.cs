// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillRandomArray(int Arg)  //Создает произвольно заполненный массив
{
    int[] Array = new int[Arg];
    for (int i = 0; i < Arg; i++)
    {
        Array[i] = new Random().Next(-10, 11);
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
    return Array;
}

int SumNotEven(int[] Array)  //Посчитывает сумму нечетных чисел
{
    int Sum = 0;
    foreach (int Buf in Array)
    {
        if (Buf % 2 != 0) Sum += Buf;
    }
    return Sum;
}

try
{
    Console.WriteLine("Введите размер массива");
    int Size = Convert.ToInt32(Console.ReadLine());
    int[] Array = new int[Size];
    Array = FillRandomArray(Size);
    int Result = SumNotEven(Array);
    Console.WriteLine("Количество четных чисел в массиве: " + Result);
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}