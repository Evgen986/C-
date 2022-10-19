/*  Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
               Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
Console.Clear();

Main();

void Main() {
int num1 = GetNum();
int num2 = GetNum();
int num3 = GetNum();
CheckTriangle(num1, num2, num3);
}

int GetNum()
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

void CheckTriangle(int num, int num2, int num3)
{
    if (num > 0 && num2 > 0 && num3 > 0)
    {
        if ((num + num2) > num3 && (num2 + num3) > num && (num3 + num) > num2)
        {
            Console.WriteLine($"Треугольник со сторонами {num}, {num2}, {num3} существует");
        }
        else
        {
            Console.WriteLine($"Треугольник со сторонами {num}, {num2}, {num3} не существует");
        }
    }else{
        Console.WriteLine($"Треугольник со сторонами {num}, {num2}, {num3} не существует");
    }
}