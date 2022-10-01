//Цикл по рисованию точек по полю терминала.
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
Console.Clear();

int xa = 40,  ya = 1,
    xb = 1,  yb = 15,
    xc = 80, yc = 15;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;  //Создаём случайную точку х и задаём значения xa, xb.

int count = 0;       //Создам счётчик циклов, который будет определять, какое кол-во раз находим отрезки и делим их пополам.  

while (count < 10000)
{
    int what = new Random().Next(0, 3); //Мы будем выбирать одну из трёх точек. Генерируем случайное число в интервале [0;3) 0 1 2 
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;              //можно так: count +=1; или count++
}
//Фрактальное изображение триугольник Серпинского. 