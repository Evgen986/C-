/*  Задача 44: Не используя рекурсию, выведите первые
               N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
               Если N = 5 -> 0 1 1 2 3
               Если N = 3 -> 0 1 1
               Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();

Main();

void Main()
{
int n = GetNum();
int [] array = Fibonscci(n, 0, 1);
PrintArray(array);
}

int GetNum()
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
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

int [] Fibonscci (int num, int num1, int num2){
    int [] fib = new int[num];
    fib[0] = num1;
    fib[1] = num2;
    for (int i = 2; i<fib.Length; i++){
        fib[i] = fib[i-1] + fib[i-2]; 
    }
return fib;
}