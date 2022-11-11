/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
              m = 2, n = 3 -> A(m,n) = 9
              m = 3, n = 2 -> A(m,n) = 29
*/
Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите число №1: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число №2: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(AkkermanRec(m, n));
}


int AkkermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanRec(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanRec(m - 1, AkkermanRec(m, n - 1));
    return AkkermanRec(m, n);
}