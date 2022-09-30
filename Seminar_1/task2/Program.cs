Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if (number > 1 || number < 7)
{
    if (number == 1)
    {
        Console.WriteLine("1 - соответсвует понедельнику");
    }
    if (number == 2)
    {
        Console.WriteLine("2 - соответсвует вторнику");
    }
    if (number == 3)
    {
        Console.WriteLine("3 - соответсвует среде");
    }
    if (number == 4)
    {
        Console.WriteLine("4 - соответсвует четвергу");
    }
    if (number == 5)
    {
        Console.WriteLine("5 - соответсвует пятнице");
    }
    if (number == 6)
    {
        Console.WriteLine("6 - соответсвует субботе");
    }
    if (number == 7)
    {
        Console.WriteLine("7 - соответсвует воскресенью");
    }
} if (number < 1 || number > 7)
    {
    Console.WriteLine("Вы ввели некорректное число");
    }