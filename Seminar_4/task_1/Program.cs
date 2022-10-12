/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
             7 -> 28
             4 -> 10
             8 -> 36

*/
Console.Clear();

Console.WriteLine ("Введите число: ");
int num = int.Parse(Console.ReadLine());
int Sum (int a){
    int sum = 0;
    for (int i = a; i>=1; i--){
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine("Сумма чисел от 1 до числа " + num + " = " + Sum(num));
