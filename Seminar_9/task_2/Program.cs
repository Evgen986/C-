/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/

Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите число a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите число b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(Numbers(a, b));
}

string Numbers(int a, int b)
{
    if (a < b) return Numbers(a + 1, b) + $"{a} ";
    else return $"{b}";
}
