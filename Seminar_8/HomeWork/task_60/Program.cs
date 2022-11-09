/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

Main();

void Main()
{
    Console.Clear();
    int[,,] array = GetArray(2, 2, 2);
    Console.WriteLine("Массив со случайными значениями:");
    PrintArray(array);

}

int[,,] GetArray(int sizeArray1, int sizeArray2, int sizeArray3)
{
    int[,,] array = new int[sizeArray1, sizeArray2, sizeArray3];
    int count = 100;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = count;
                count--;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j, 0]}({i},{j},0) ");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 1; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}