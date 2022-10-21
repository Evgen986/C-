//  Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int [,] array = GetArray(rows, columns, 0,10);

PrintArray(array);
SquareEvenIndex(array);
PrintArray(array);

int[,] GetArray (int sizeRows, int sizeColumns, int minValue, int maxValue) // Создание двумерного массива и заполнение его случайными числами в указ. диапозоне
{
    int[,] arr = new int[sizeRows, sizeColumns];
    for (int i = 0; i < sizeRows; i++)
    {
        for (int j = 0; j < sizeColumns; j++)
        {
        arr[i,j] = new Random().Next(minValue, maxValue+1);    
        }
        
    }
    return arr;
}

void SquareEvenIndex (int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i=i+2)
    {
        for (int j = 0; j < array.GetLength(1); j=j+2)
        {
        array[i,j] = array[i,j]*array[i,j];    
        }
        
    }
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