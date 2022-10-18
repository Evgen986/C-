string[,] table = new string[2, 5];
// table [0,0]  table [0,1]  table [0,2]  table [0,3]  table [0,4]
// table [1,0]  table [1,1]  table [1,2]  table [1,3]  table [1,4]
// table [1, 2] = "слово";

// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.Write($" -{table[i, j]}-");
//     }
//     Console.Write();
// }

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}