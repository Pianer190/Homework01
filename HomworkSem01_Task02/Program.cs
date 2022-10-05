//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введи 3 числа и узнай максимальное  ");

int a = 1;
int b = 2;
int c = 6;

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max =");
Console.WriteLine(max);
