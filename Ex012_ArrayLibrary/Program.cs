//Методы заполнения, вывода значения и поиска элемента массива.

void FillArray(int[] collection)      //1. Метод заполнения массива случайными числами
{                                                      //тело метода:
    int length = collection.Length;                     //выясняем кол-во эл-тов массива
    int index = 0;                                      //задаём значение индекса для старта цикла
    while (index < length)                              //задаём условие цикла
    {                                                  //тело цикла 
        collection[index] = new Random().Next(1, 10);   //заполняем массив случайными цифрами в диапазоне от 1 до 10
        index++;                                        //шаг цикла +1 для полного заполнения значениями массива
    }
}

void PrintArray(int[] col)            //2. Метод вывода значений массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)  //3. Метод поиска элемента в массиве и вывод его индекса
{
    int count = collection.Length;
    int index = 0;
    int position = 0;                   //можно указать -1, чтобы выводил в случае отсутствия эл-та не 0.
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;                      //чтобы найдя первый элемент на этом и остановится /в противном случае выводит последний 
        }
        index++;
    }
    return position;
}

int[] array = new int[10];            //создаём новый массив с 10ю элементами

FillArray(array);                     //запускаем наш метод по заполнению случайными числами нашего массива
//array[4] = 4;                       - так принудительно можно добавить нужные значения в наш массив для вывода в консоль
//array[6] = 4;                        
PrintArray(array);                    //запускаем наш метод по выводу значений нашего массива array в консоль
Console.WriteLine();                  //пустая строка между выводом массива сверху

int pos = IndexOf(array, 4);          //задаём переменную pos куда поместим результат работы нашего массива IndexOf
                                      //в аргументах метода указываем имя нашего массива array и значение 4 индекс которого ищем
Console.WriteLine(pos);               //выводим в консоль значение переменной pos, номер индекса нашего элемента массива


