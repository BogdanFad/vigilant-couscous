Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. ");
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
   string str = Convert.ToString(a);
   Console.Write("Третья цифра: ");
   Console.WriteLine(a/100%10); 
}