/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            M = 1; N = 15 -> 120
            M = 4; N = 8. -> 30
*/
Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите число №1: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число №2: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(SumNumbersRec(m, n));
}


int SumNumbersRec(int m, int n)
{
    if (n < m) return 0;
    else return n + SumNumbersRec(m, n - 1);
}