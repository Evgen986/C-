/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

Main();

void Main()
{
    Console.Clear();
    int[,,] array = GetArray(4, 4, 4);
    Console.WriteLine("Массив со случайными значениями:");
    PrintArray(array);

}

int[,,] GetArray(int sizeRows, int sizeColumns, int sizeArray3)
{
    int[,,] array = new int[sizeRows, sizeColumns, sizeArray3];
    int count = 100;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k =0; i < array.GetLength(2); k++){
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
            for (int k = 0; k<array.GetLength(2); k++){
                Console.Write($"{array[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}