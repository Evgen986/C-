/*  Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
                Например, задан массив:
                1 4 7 2
                5 9 2 3
                8 4 2 4
                Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.Clear();
int[,] array = GetArray(6, 8, 0, 10);
PrintArray(array);
Console.Write(SumElementsMainDiagonal(array));

int SumElementsMainDiagonal(int[,] arr)
{
    int count = 0;
    int count2 = 0;
    if (arr.GetLength(0)>arr.GetLength(1)){
        count2=arr.GetLength(1)-1;
    }else{
        count2=arr.GetLength(0)-1;
    }
    int result = 0;
    string temp = "Сумма элементов главной диагонали: ";
    while (count <= count2)
    {
        temp += arr[count, count] + " ";
        result += arr[count, count];
        count++;
    }
    temp = temp + " = ";
    Console.Write(temp);
    return result;

}

int[,] GetArray(int sizeRows, int sizeColumns, int minValue, int maxValue) // Создание двумерного массива и заполнение его случайными числами в указ. диапозоне
{
    int[,] arr = new int[sizeRows, sizeColumns];
    for (int i = 0; i < sizeRows; i++)
    {
        for (int j = 0; j < sizeColumns; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}