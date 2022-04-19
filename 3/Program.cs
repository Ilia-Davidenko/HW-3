using System;
using static System.Console;

WriteLine("Введите число");
int x = int.Parse(ReadLine());
int count = 1;

while (count<=x)
{
    double x1 = Math.Pow(count,3);
    count++;
    Write($"{x1} ");
}