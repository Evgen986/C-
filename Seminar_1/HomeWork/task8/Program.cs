// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number2 = number % 2;
if (number2 == 0)
{
    for (int i = number; i > 0; i = i - 2)
    {
        Console.Write(i + ", ");
    }
}
else
{
    number = number - 1;
    for (int i = number; i > 0; i = i - 2)
    {
        Console.Write(i + ", ");
    }
}