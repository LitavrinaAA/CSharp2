﻿//числа фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonachi(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachi(n - 1) + Fibonachi(n - 2);
}

for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine(Fibonachi(i));
}

