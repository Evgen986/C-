int[] array = { 58, 96, 4, 8, 3, 486, 5, 66, 4 };

int find(int[] array1, int find1)
{
    int count = -1;
    for (int i = 0; i < array1.Length; i++)
    {
        if (find1 == array1[i])
        {
            count = i;
            break;
        }
    }
    return count;
}

int position = find(array, 487);
Console.WriteLine("Искомое число находится в ячейке: " + position);