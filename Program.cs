﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите по очереди два числа:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2) Console.WriteLine("Больше число:"+num1);
    else
    Console.WriteLine("Больше число:"+num2);
*/
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите по очереди три числа:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int max = 0;
if (num1 > num2) max = num1;
if (num3 > max) max = num3;
Console.WriteLine("Больше число:"+max);
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
    
        Console.WriteLine("Это чётное число");
    
    else
    
        Console.WriteLine("Это Нечётное число");
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());
int i = 0;
while (i < N)
 {if (i % 2 ==0) 
  Console.WriteLine(i);
  i = (i + 1);}
*/