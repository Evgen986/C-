Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 1000)
{
    Console.WriteLine("Введите корректное число!");
}
else
{
    int a = number % 10;
    Console.WriteLine(a);
}