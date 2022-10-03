int[] array = new int[10];

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] col)
{
    int index = col.Length;
    int count = 0;
    while (count < index)
    {
        Console.Write(col[count] + ", ");
        count++;
    }
    Console.WriteLine();
}

int IndexOf(int[] collection, int find)
{
    int all = collection.Length;
    int count = 0;
    int position = -1;
    while (count < all)
    {
        if (find == collection[count])
        {
            position = count;
            break;
        }
        count++;
    }
    return position;

}
FillArray(array);
PrintArray(array);
Console.Write("Введите число, которое нужно найти: ");
int find = int.Parse(Console.ReadLine());
Console.WriteLine("Искомое число в ячейке: " + IndexOf(array, find));