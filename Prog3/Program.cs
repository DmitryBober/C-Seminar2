// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
int n = day;
int weekday = 5;

if (n > weekday)
{
    Console.WriteLine("Выходной день");
}
else
{ 
    Console.WriteLine("Будний день");
}