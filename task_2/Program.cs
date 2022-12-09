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

int SumNotEven(int[] Array)  //Посчитывает сумму чисел на нечетных позициях
{
    int Sum = 0;
    for (int i = 0; i < Array.Length; i += 2)
    {
        Sum += Array[i];
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
    Console.WriteLine("Сумма чисел на нечетных позициях: " + Result);
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}