/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M = Read("M");
int N = Read("N (больше или равно M)");

int Read(string arg)
{
    System.Console.WriteLine($"Введите число {arg}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Summ(int M, int N)
{
    if (M <= N) return M + Summ(M+1, N); 
    else return 0;
}
System.Console.WriteLine(" ");
System.Console.WriteLine($"-> "+ Summ(M, N));