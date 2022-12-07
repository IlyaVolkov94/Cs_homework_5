//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillRandomArray(int Arg)  //Создает произвольно заполненный массив
{
    double[] Array = new double[Arg];
    for (int i = 0; i < Arg; i++)
    {
        Array[i] = Math.Round(new Random().NextDouble() * 10, 2);
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
    return Array;
}

double DiffMaxMinArray(double[] Array)  //Посчитывает сумму нечетных чисел
{
    double Max = Array[0];
    double Min = Array[0];
    foreach (double Buf in Array)
    {
        if (Buf > Max) Max = Buf;
        if (Buf < Min) Min = Buf;
    }
    return Math.Round(Max - Min, 2);
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