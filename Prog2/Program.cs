// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num = 38900;
Console.WriteLine(num);
string str = num.ToString();

if (num == 38900)
{
    Console.WriteLine(str[2]);
}
 else 
 {
    Console.Write("Третьей цифры нет:(");
 }