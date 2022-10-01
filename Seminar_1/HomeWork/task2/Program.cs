Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
int min = number2;
if (number2>max){
    max=number2;
    min=number1;
}
Console.WriteLine("Большее число: " + max);
Console.WriteLine("Меньшее число: " + min);