/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

double M = Read("положительное число M");
double N = Read("положительное число N");

double Read(string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    return double.Parse(Console.ReadLine());
}

double Ackermann(double M, double N)
{
    if (M > 0 && N == 0) return Ackermann(M-1, 1);
    else if (M > 0 && N > 0) return Ackermann(M-1, Ackermann(M, N-1));
    else if (M == 0) return N = N+1; return N;
}
System.Console.WriteLine(Ackermann(M, N));