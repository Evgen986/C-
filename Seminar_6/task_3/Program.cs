/*  Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
               45 -> 101101
               3  -> 11
               2  -> 10
*/
Console.Clear();

Main();

void Main()
{
    int num = GetNum();
    Console.WriteLine(num);
    int[] array = InBinary(num);
    PrintArray(array);
}

int GetNum()
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] InBinary(int num)
{
    int count = 0;
    int temp = num;
    while (temp > 0)
    {
        temp /= 2;
        count++;
    }
    int[] binary = new int[count];
    for (int i = binary.Length-1; i >= 0; i--)
    {
        binary[i] = num % 2;
        num /= 2;
    }
    return binary;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i] + "]");
        }
    }
    Console.WriteLine();
}