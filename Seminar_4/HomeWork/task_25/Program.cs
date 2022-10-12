/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
             3, 5 -> 243 (3⁵)
             2, 4 -> 16
*/
Console.Clear();

Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {numberA} в степени {numberB} = {Pow(numberA, numberB)}");

int Pow(int number1, int number2)
{
    int result = 1;
    while (number2 > 0)
    {
        result *= number1;
        number2--;
    }
    return result;
}