Console.Clear();

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

//метод вывода массива на экран.
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод упорядочивания массива от мин к макс.
void SelectoinSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array [minPosition] = temporary;
    }
}

PrintArray(arr);
SelectoinSort(arr);
PrintArray(arr);

/*

//метод вывода массива на экран.
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод упорядочивания массива от макс к мин.
void SelectoinSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for (int j = i; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array [maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectoinSort(arr);
PrintArray(arr);
*/