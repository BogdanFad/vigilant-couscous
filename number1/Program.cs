Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. ");
Console.WriteLine("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine()!);
if (a > 999 || a < 100)
{
    Console.WriteLine("Число введено неверно!");
}
else
{
   Console.Write("Второй цифрой является: ");
   Console.WriteLine(a/10%10); 
}