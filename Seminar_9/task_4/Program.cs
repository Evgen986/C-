/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

Main();

void Main()
{
    Console.Clear();
    int a = 2;
    int b = 5;
    Console.WriteLine(PowRec(a, b));
}

int PowRec(int a, int b)
{
    if (b == 0) return 1;
    else return a * PowRec(a, b - 1);
}