/*  Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
               m = 3, n = 4.
               1 4 8 19
               5 -2 33 -2
               77 3 8 1
*/

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray (int sizeRows, int sizeColumns, int minValue, int maxValue) // Создание двумерного массива и заполнение его случайными числами в указ. диапозоне
{
    int[,] arr = new int[sizeRows, sizeColumns];
    for (int i = 0; i < sizeRows; i++)
    {
        for (int j = 0; j < sizeColumns; j++)
        {
        arr[i,j] = new Random().Next(minValue, maxValue + 1);    
        }
        
    }
    return arr;
}

void PrintArray(int[,] arr)                          // Вывести двумерный массив в консоль
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}