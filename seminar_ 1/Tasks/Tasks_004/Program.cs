﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
//5->2, 4
//8->2, 4, 6, 8
System.Console.WriteLine("Введите  число");
int a  = Convert.ToInt32 (Console.ReadLine ());
for (int b = 2; b <= a; b+=2)  
{
    
    Console.Write(b);    
}
System.Console.Write("Список четных чисел ");