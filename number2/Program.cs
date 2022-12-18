Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. ");
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string Number = Convert.ToString(a);
if (Number.Length > 2)
{
  Console.WriteLine("третья цифра: " + Number[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}