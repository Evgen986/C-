/*  Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
                m = 3, n = 4.
                0 1 2 3
                1 2 3 4
                2 3 4 5
*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);

int[,] GetArray (int sizeRows, int sizeColumns) // Создание двумерного массива и заполнение его случайными числами в указ. диапозоне
{
    int[,] arr = new int[sizeRows, sizeColumns];
    for (int i = 0; i < sizeRows; i++)
    {
        for (int j = 0; j < sizeColumns; j++)
        {
        arr[i,j] = i+j;    
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