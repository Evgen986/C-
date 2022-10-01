// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number2 = number % 2;
if (number2 == 0)
{
    Console.WriteLine("Число: " + number + ", является четным.");
}
else
{
    Console.WriteLine("Число: " + number + ", является нечетным.");
}