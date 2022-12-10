//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillRandomArray(int arg)
{
    double[] array = new double[arg];
    for (int i = 0; i < arg; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 10, 2);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
    return array;
}

double DiffMaxMinArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach (double buf in array)
    {
        if (buf > max) max = buf;
        if (buf < min) min = buf;
    }
    return Math.Round(max - min, 2);
}

try
{
    Console.WriteLine("Введите размер массива");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[arraySize];
    array = FillRandomArray(arraySize);
    double result = DiffMaxMinArray(array);
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + result);
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}