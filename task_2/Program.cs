// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillRandomArray(int arg)
{
    int[] Array = new int[arg];
    for (int i = 0; i < arg; i++)
    {
        Array[i] = new Random().Next(-10, 11);
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
    return Array;
}

int SumNotEven(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        Sum += array[i];
    }
    return Sum;
}

try
{
    Console.WriteLine("Введите размер массива");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[arraySize];
    array = FillRandomArray(arraySize);
    int result = SumNotEven(array);
    Console.WriteLine("Сумма чисел на нечетных позициях: " + result);
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}