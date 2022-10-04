/*
Имеется одномерный массив array из n элементов,
требуется найти элемент массива, равный find.
1. Устоновить счётчик index в позицию 0.
2. Если array[index] = find, алгоритм завершил работу успешно.
3. Увеличить index на 1.
4. Если index < n, то перейти к шагу 2. В противном случае
алгоритм завершил работу безуспешно.
*/

int[] array = { 1, 12, 31, 41, 51, 61, 61, 17, 8, 61 };

int n = array.Length;  //.Length - возвращает информацию о длине или кол-ве элементов в массиве
int find = 61;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);  //если есть одинаковые элементы в массиве
        break;                     //и чтобы не выводить их всех, а прерваться на первом найденом
    }
    index++;                       //index = index + 1;
}

/*
Console.Clear();

int[] array = { 1, 12, 31, 41, 51, 61, 61, 17, 8, 61 };

int n = array.Length;  

Console.WriteLine("Введите искомое значение: ");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine($"Индекс искомого в массиве: {index}");  
        break;                     
    } 
    index++;                   
}

Console.WriteLine($"Искомое в массиве отсутствует!");       
*/
 