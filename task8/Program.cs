// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого

Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if((numB == numA * numA) || (numA == numB * numB))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}