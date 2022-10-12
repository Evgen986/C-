/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
             4 -> 24 
             5 -> 120
*/
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine ($"Произведение чисел от {num} до 1 = {GetProduct(num)}");
int GetProduct(int number){
    /*int product = number;
    for (int i = 1; i<number; i++)
    {
            product *= i;
    }
    */
    // ЧЕРЕЗ РЕКУРСИЮ
    if(number == 1){
    return 1;
    }
    int result = GetProduct(number-1)*number;
    number--;
    return result;
}