/*
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int a1 = num/100*10;
int a2 = num%10;
int a3 = a1+a2;

Console.WriteLine(a3);