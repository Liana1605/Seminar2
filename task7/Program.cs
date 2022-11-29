// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine("Кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine("Не кратно");
}