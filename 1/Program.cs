/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int num;
int Read()
{
    System.Console.WriteLine("Введите число: ");
    num = int.Parse(Console.ReadLine());
    return num;
}

string Recursion(int num)
{
    string result = string.Empty;
    if (num >= 1) return $"{num} " + Recursion(num-1);
    else return string.Empty;
}
Read();
System.Console.WriteLine(" ");
System.Console.WriteLine($"Число = {num} -> " + Recursion(num));