// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов.
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

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

void SortArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        for (int j = i; j < Array.Length; j++)
        {
            if (Array[i] < Array[j])
            {
                int Buf = Array[i];
                Array[i] = Array[j];
                Array[j] = Buf;
            }
        }
        Console.Write(Array[i] + " ");
    }
}


Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());
int[] BufArray = new int[Size];
BufArray = FillRandomArray(Size);
SortArray(BufArray);