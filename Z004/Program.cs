/*Напишите программу, которая считывает с консоли числа
(по одному в строке) до тех пор, пока сумма введённых чисел
не будет равна 0 и сразу после этого выводит сумму квадратов 
всех считанных чисел.
Гарантируется, что в какой-то момент сумма введённых чисел
окажется равной 0, после этого считывание продолжать не нужно.
В примере мы считываем числа 1, -3, 5, -6, -10, 13;
в этот момент замечаем, что сумма этих чисел равна нулю
и выводим сумму их квадратов, не обращая внимания на то, 
что остались ещё не прочитанные значения.﻿
На входе:
1
-3
5
-6
-10
13
4
-8
На выходе:
340 */

Console.WriteLine("Количество вводимых чисел");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Введите числа");

int[] FillArray(int[] collection)
{
    int b = collection.Length;
    int index = 0;
    while (index < b)
    {

        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    return collection;
}
int Sum0()
{
    int s = 0;
    int kvsum = 0;
    int i = 0;
    while (i < n)
    {
        s += array[i];
        kvsum += array[i] * array[i];
        i++;
        if (s == 0)
        {
            Console.WriteLine("сумму квадратов " + kvsum);
            break;
        }
    }
    if (s != 0) Console.WriteLine("Сумма не равна нулю ");
    return s;
}

try
{
    FillArray(array);
    Sum0();
}
catch
{
    Console.Write("Надо было вводить числа");
    Console.ReadLine();

}
