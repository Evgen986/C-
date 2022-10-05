/*
12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
Console.Clear();
Console.WriteLine("Введите число №1: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №1: ");
int num2 = int.Parse(Console.ReadLine());
int a = 0;
if (num > num2)
{
    a = num % num2;
}
if (num < num2)
{
    a = num2 % num;
}
if (a == 0)
{
    Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine($"Число некратно, остаток {a}");
}