Console.WriteLine("Задача 13: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. ");
Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");
int DayNumber = int.Parse(Console.ReadLine());
if (DayNumber < 1 || DayNumber > 7)
{
    Console.WriteLine("Дня недели с таким номером не сущетсвует");
}
if (DayNumber > 5 && DayNumber < 8)
{
    Console.WriteLine("Ура! Сегодня выходной:)");
}
if (DayNumber >= 1 && DayNumber < 6)
{
    Console.WriteLine("Сегодня рабочий день!");
}     