//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillRandomArray(int Arg)  //Создает произвольно заполненный массив
{
    double[] Array = new double[Arg];
    for (int i = 0; i < Arg; i++)
    {
        Array[i] = new Random().Next(-10, 11);
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
    return Array;
}

double DiffMaxMinArray(double[] Array)  //Посчитывает сумму нечетных чисел
{
    double Max =0;
    double Min =0;
    foreach (double Buf in Array)
    {
        if (Buf > Max) Max = Buf;
        if (Buf < Min) Min = Buf;
    }
    return Max-Min;
}

try
{
    Console.WriteLine("Введите размер массива");
    int Size = Convert.ToInt32(Console.ReadLine());
    double[] Array = new double[Size];
    Array = FillRandomArray(Size);
    double Result = DiffMaxMinArray(Array);
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + Result);
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}