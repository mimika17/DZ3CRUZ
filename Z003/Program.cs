/*Задача 23
Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int TableCube()
{
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write(i*i*i+", ");
}
return n;
}
try
{
TableCube();
Console.ReadLine();
}
catch
{
    Console.WriteLine("введите цифры");
    Console.ReadLine();
}