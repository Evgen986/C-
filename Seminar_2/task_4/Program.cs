/*
16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.Clear();
Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число : ");
int num2 = int.Parse(Console.ReadLine());

int min = num;
int max = num2;
if(num2<min){
    min=num2;
    max=num;
}

if(max == min*min){
    Console.WriteLine($"Число {max} является квадратом числа {min}");
}else{
    Console.WriteLine($"Число {max} неявляется квадратом числа {min}");
}