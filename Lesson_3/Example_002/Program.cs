/* Напишите метод который будет отсортировывать массив от минимального к максимальному
*/
int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

int[] sortarray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        for (int j = i+1; j < length; j++)
        {
            int temp = 0;
            if (array[j] < array[i])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}
void printArray(int[] array)
{
    int count = array.Length;
    Console.Write("[ ");
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1)
        {
            Console.Write("]");
        }
        else
            Console.Write(array[i] + ", ");
    }
}
int[] temp = sortarray(array);
printArray(temp);