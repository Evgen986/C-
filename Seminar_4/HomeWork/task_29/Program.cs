/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
             1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
             6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]
*/
Console.Clear();
int[] array = new int[8];

FillingArray(array);
PrintArray(array);


void FillingArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 1000);
    }
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
}