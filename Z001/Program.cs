/*Задача 19
Напишите программу, которая принимает
на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int PalindromeFive()
{
    Console.WriteLine("Введите пятизначное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    string a1 = Convert.ToString(a);
    if (a1[0] == a1[4] && a1[1] == a1[3]) Console.WriteLine("да");
    else Console.WriteLine("нет");
    return a;
}
try
{
    PalindromeFive();
}
catch
{
    Console.WriteLine("введите пятизначное число");
}
