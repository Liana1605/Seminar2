﻿// Напишите программу, которая выводит случайное число из отрезка (10, 99) и показывает наибольшую цифру
int a = new Random().Next(10, 99);
Console.WriteLine(a);

int a2 = a % 10;
int a1 = a / 10;
int result = Math.Max(a1, a2);
Console.WriteLine(result);
