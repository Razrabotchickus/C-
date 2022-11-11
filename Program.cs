// Семинар 1
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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
//Семинар 2
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*Console.Write("Введите трёхзначное число:");
string num = (Console.ReadLine());
int num1 = Convert.ToInt32(num);
    if  (num1 < 999 && num1 >0 )
        { Console.WriteLine(num[1]); }
    else { Console.WriteLine("Введено не трехзначное число"); }
    */

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*Console.Write("Введите трёхзначное число:");
string num = (Console.ReadLine());
int num1 = Convert.ToInt32(num);
    if  (num1 < 99 && num1 >0 )
        { 
            Console.WriteLine("Третьей цифры нет");
              }
         else if (num1 >0 )
        {
             Console.WriteLine(num[2]);
              }
              */
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*Console.Write("Введите день недели от 1 до 7:");
string[] Days = { "нет","нет","нет","нет","нет","да","да" };
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Days[num]); */
//Семинар 3
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*Console.Write("Введите пятизначное число:");
string num = (Console.ReadLine());
    if  (num[0]==num[4] && num[1]==num[3])
        { 
             Console.WriteLine("да");
              }
    else   {Console.WriteLine("нет");}
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.            
/*
string[] A = new string[3] { "x", "y", "z" };
string[] B = new string[3] { "x1", "y1", "z1" };
Console.WriteLine("Введите первую координату первой точки");
    int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату первой точки");
    int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью координату первой точки");
    int z = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату второй точки");
    int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату второй точки");
    int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью координату второй точки");
    int z1 = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1,2)+ Math.Pow(z - z1,2));
Console.WriteLine(result);
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
int i;
  for (i=1; i<=N; i++)
    {
        double kub = Math.Pow(i, 3);
        Console.WriteLine(kub);
    }
*/
//Семинар 4
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
/*Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень:");
int Stepen = int.Parse(Console.ReadLine());
if (N>0 && Stepen>0)  
        { double Result = Math.Pow(N, Stepen);
             Console.WriteLine(Result);
              }
    else   {
        Console.WriteLine("Вы ввели отрицательное число");
        double Result = Math.Pow(N, Stepen);
             Console.WriteLine(Result);
    }
*/
 //   Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 /*int metod(int number)
    {  
    if (number<10)
    return number;
    int ostatok = number/10;
    int cifra = number%10;
    return cifra+metod(ostatok);
    }
 
 Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int result = metod(number);
Console.WriteLine(result);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы задаются рандомно (диапазон выбрать самостоятельно) Итоговый массив должен содержать в себе суммы цифр числа. Т.е. необходимо подсчитывать суммы цифр каждого числа и записывать их в новый массив.
/*
int metod(int x)
    {  
    if (x<10)
    return x;
    int ostatok = x/10;
    int cifra = x%10;
    return cifra+metod(ostatok);
    }
 
int[] Array = new int[8];
Random rand = new Random();
            
        for (int x = 0; x < Array.Length; x++)
            {
                Array[x] = rand.Next(99);
                Console.WriteLine("Рандомное значение элемента массива " + x + " = " + Array[x]);
            }
          Console.WriteLine();
        for (int y = 0; y < Array.Length; y++)
            {
                Array[y] = metod(Array[y]);
                Console.WriteLine("Cумма чисел элемента массива " + y + " = " + Array[y]);
            }
     */ 

     //Семинар 6
     //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
   /* Console.Write("Введите колличество чисел:");
    int lenght = int.Parse(Console.ReadLine());
    int[] Array = new int[lenght];
    int count = 0;
    for (int x = 0; x < Array.Length; x++)
        {
        Console.Write($"Введите число {x+1}:");
        Array[x]=int.Parse(Console.ReadLine());
        } 
    for (int x = 0; x < Array.Length; x++)
        {
        if (Array[x]>0) 
        count = count+1;
        }
        Console.WriteLine($"Количество чисел больше 0:  {count}");
        */

        /*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
        заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        Console.Write("Введите b1:");
        int b1=int.Parse(Console.ReadLine());
        Console.Write("Введите k1:");
        int k1=int.Parse(Console.ReadLine());
        Console.Write("Введите b2:");
        int b2=int.Parse(Console.ReadLine());
        Console.Write("Введите k2:");
        int k2=int.Parse(Console.ReadLine());

        На потом как нибудь

        */


        //Урок 7. Как не нужно писать код. Часть 1
        //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
      /*
        Console.Write("Введите размерность массива m:");
        int m =int.Parse(Console.ReadLine());
        Console.Write("Введите размерность массива n:");
        int n =int.Parse(Console.ReadLine());

        void PrintArray(int[,] matr)
            {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
            Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
            }
            }
            void FillArray(int[,] matr)
            {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
            matr[i,j] = new Random().Next(-10,10);//[1; 10)
            }
            }
            }
            int[,] matrix = new int[m, n];
            FillArray(matrix);
            Console.WriteLine();
            PrintArray(matrix);
*/
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
        Console.Write("Введите размерность массива m:");
        int m =int.Parse(Console.ReadLine());
        Console.Write("Введите размерность массива n:");
        int n =int.Parse(Console.ReadLine());

        void PrintArray(int[,] matr)
            {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
            Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
            }
            }
            void FillArray(int[,] matr)
            {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
            matr[i,j] = new Random().Next(-10,10);//[1; 10)
            }
            }
            }
            int[,] matrix = new int[m, n];
            FillArray(matrix);
            Console.WriteLine();
            PrintArray(matrix);
        Console.Write("Введите первую позицию элемента массива:");

        int a =int.Parse(Console.ReadLine());
        Console.Write("Введите вторую позицию элемента массива:");
        int b =int.Parse(Console.ReadLine());
        if (a > m | b > n) 
        Console.Write("Такого числа в массиве нет");
        Console.Write(matrix[a,b]);
*/
/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/
       Console.Write("Введите размерность массива m:");
        int m =int.Parse(Console.ReadLine());
        Console.Write("Введите размерность массива n:");
        int n =int.Parse(Console.ReadLine());
        void PrintArray(int[,] matr)
            {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
            Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
            }
            }
            void FillArray(int[,] matr)
            {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
            matr[i,j] = new Random().Next(0,10);//[1; 10)
            }
            }
            }
            int[,] matrix = new int[m, n];
            FillArray(matrix);
            Console.WriteLine();
            PrintArray(matrix);

   
     
     for (int j = 0; j < n; j++)    //ошибки выдает, не понимаю как сделать 
            {
                int sum = 0;
                int arr=0;
                int row=0;
                int sr_z=0;
                int sred=0;
                for (int i = 0; i < m; i++)
                {
                    arr[i, j] = row.Next(1, 10);
                    sum += arr[i, j]; 
                }
                sr_z = sum / m; 
                sred[j] = sr_z; 
            }
