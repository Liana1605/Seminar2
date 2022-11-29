// Напишите программу, которая будет принимать на вход и выводить, 
// является ли второее число кратным первому. 
// Если число 2 не кратно 1, то программа выводит остаток от деления

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA % numberB;
if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {result}");
}