/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
             452 -> 11
             82 -> 10
             9012 -> 12
*/
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма чисел в числе {number} = {SumNumbers(number)}");

int SumNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}