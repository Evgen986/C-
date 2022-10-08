/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
             5 -> 1, 4, 9, 16, 25.
            2 -> 1,4

*/

Console.Clear();
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
Console.Write(number + " -> ");
for (int i = 1; i <= number; i++)
{
    double temp = Math.Pow(i, 2);
    Console.Write(temp + ", ");
}