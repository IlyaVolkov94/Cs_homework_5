// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов.
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

int[] FillRandomArray(int value)  //Создает произвольно заполненный массив
{
    int[] Array = new int[value];
    for (int i = 0; i < value; i++)
    {
        Array[i] = new Random().Next(-10, 11);
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
    return Array;
}

int[] SortArray(int[] array)
{
    int[] sortArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        sortArray[i] = array[i];
    int Buf = 0;
    for (int i = 0; i < sortArray.Length; i++)
    {
        for (int j = i; j < sortArray.Length; j++)
        {
            if (sortArray[i] < sortArray[j])
            {
                Buf = sortArray[i];
                sortArray[i] = sortArray[j];
                sortArray[j] = Buf;
            }
        }
    }
    return sortArray;
}

double[] InfoArray(int[] value, int[] array)
{
    int arraySize = 5;
    double[] infoArray = new double[arraySize];
    double average = 0;
    for (int i = 0; i <= 1; i++)
    {
        infoArray[i] = value[i];
        for (int j = 0; j < array.Length; j++)
        {
            if (i == 1) average += array[j];
            if (infoArray[i] == array[j]) infoArray[i + 2] = j;
        }
    }
    infoArray[infoArray.Length - 1] = Math.Round(average / array.Length, 2);
    return infoArray;
}

void PrintInfo(double[] array)
{
    string text = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) text = "Максимальный элемент массива: ";
        if (i == 1) text = "Минимальный элемент массива: ";
        if (i == 2) text = "Индекс максимального элемента: ";
        if (i == 3) text = "Индекс минимального элемента: ";
        if (i == 4) text = "Среднее арифметическое массива: ";
        Console.WriteLine(text + array[i]);
    }
}

void PrintMedian(int[] array)
{
    int arraySize = array.Length;
    int indexMedian = arraySize / 2;
    if (arraySize % 2 != 0)
    {
        Console.WriteLine("Медианное значение: " + array[indexMedian]); //Отображаем средний элемент отсортированного масива
    }
    else
    {
        double Median = (double)(array[indexMedian] + array[indexMedian - 1]) / 2;
        Console.WriteLine("Медианное значение: " + Math.Round(Median, 2));    //Отображаем сумму двух центральных элементов массива
    }
}

try
{
Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] bufArray = new int[sizeArray];
bufArray = FillRandomArray(sizeArray);
int[] sortArray = SortArray(bufArray);
int[] MaxAndMin = new int[2];
MaxAndMin[0] = sortArray[0];
MaxAndMin[1] = sortArray[sortArray.Length - 1];
PrintInfo(
    InfoArray(
        MaxAndMin, bufArray
    )
);
PrintMedian(sortArray);
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}