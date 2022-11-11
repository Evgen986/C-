/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите число a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine(Integers(a));
}

string Integers(int n)
{
    string numbers = "";
    if (n > 1) return Integers(n - 1) + $"{n} ";
    else return $"{n} ";
}
