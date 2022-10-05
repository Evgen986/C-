/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

Console.Clear();
Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine());
int a = num%7;
int b = num%23;
if (a == 0 & b == 0){
     Console.WriteLine("Число кратно");
}else{
    Console.WriteLine("Число не кратно");
}