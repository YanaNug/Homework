﻿Console.WriteLine("Введите 2 числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a >= b)
{
    Console.WriteLine($"max={a} , min={b}");
}
else
{
    Console.WriteLine($"max={b} , min={a}");
}