/* Напишите программу, которая на вход получает размерность массива. Далее заполняет его случайными уникальными числами и выводит на экран.
Далее производим сортировку массива от большего к меньшему и выводим на экран.
Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат.
Встроенные методы работы со списками использовать нельзя.
*/

int[] FillRandomArray(int value)
{
    int[] array = new int[value];
    int temp = new Random().Next(0, value);
    int j = 0;
    for (int i = 0; i < value; i++)
    {
        while (j < i)
        {
            if (array[j] == temp)
            {
                temp = new Random().Next(0, value);
                j = 0;
            }
            else j++;
        }
        array[i] = temp;
    }
    return array;
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}

int[] MixArray(int[] array)
{
    int arraySize = array.Length;
    int[] firstIndexes = FillRandomArray(arraySize);
    int[] secondIndexes = FillRandomArray(arraySize);
    int[] mixArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        mixArray[secondIndexes[i]] = array[firstIndexes[i]];
    }
    return mixArray;
}

try
{
    Console.WriteLine("Введите размер массива");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    int[] bufArray = FillRandomArray(arraySize);
    Console.WriteLine("Рандомный массив:");
    PrintArray(bufArray);
    bufArray = SortArray(bufArray);
    Console.WriteLine("Отсортированный массив:");
    PrintArray(bufArray);
    bufArray = MixArray(bufArray);
    Console.WriteLine("Переменашанный массив:");
    PrintArray(bufArray);
}

catch
{
    Console.WriteLine("Ошибка выполенения");
}