/*
Найти максимум из 9ти чисел.
Var2. Функции/Методы + Массив.
*/
Console.Clear();

int Max(int arg1, int arg2, int arg3)  //Функция/метод возвращаемого типа и возвращать будем (int ...)
{
    int result = arg1;
    if(arg2 > result) result = arg2;   //Тело функция/метод
    if(arg3 > result) result = arg3;
    return result;                     //И далее нам нужно чтобы функция/метод возвратил result
}                                      //Таким образом у нас есть механизм который ищет макс из трёх чисел

int[] array = {11, 12, 34, 55, 88, 99, 87, 45, 9};

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));  

Console.WriteLine(max);

/*
Как ввести значение по индексу массива и 
вывести в консоль значение из массива:
int[] array = {11, 12, 34, 55, 88, 99, 87, 45, 9};

array[0] = 12;
Console.WriteLine(array[4]);
*/