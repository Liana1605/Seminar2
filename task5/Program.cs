// Напишите программу, которая выдает случайное трехзначное число и удаляет вторую цифру этого числа
int a = new Random().Next(100, 999);
Console.WriteLine(a);

int a3 = a % 10;
int a1 = a / 100;
int result = (a1 * 10 + a3);
Console.WriteLine(result);