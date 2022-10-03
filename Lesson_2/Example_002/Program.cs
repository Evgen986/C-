int[] array = { 9, 28, 15980, 32, 1990 };
int Max(int[] array1)
{
    int max = array1[0];
    for (int i = 1; i < array1.Length; i++)
    {
        if (array1[i] > max)
        {
            max = array1[i];
        }
    }
    return max;
}

Console.WriteLine("Максимальное число в массиве:" + array.Max());