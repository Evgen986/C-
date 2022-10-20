int[] array = { -15, -27, 6, -9, 1, 64 };
Console.WriteLine();



PrintArray(array);                  // Вывести массив в консоль
FindNumArray(array, 6);             // Есть ли заданное число в массиве
FindPerfectSquares(array);          // Квадратные числа в массиве
FindPerfectCubes(array);            // Кубические числа в массиве
OddNumCount(array);                 // Колличество нечетных чисел в массиве
NegativeNumCount(array);            // Количество отрицательных чисел в массиве
PositiveNumCount(array);            // Количество положительных чисел в массиве
EvenNumCount(array);                // Колличество четных чисел в массиве
FindNumsRange(array, 1, 10);        // Количество чисел в указанном диапозоне
CopyArray(array);                   // Копирование массива
FindMax(array);                     // Максимальное значение в массиве
FindSecondMax(array);               // Максимальное значение №2 в массиве
FindThirdMax(array);                // Максимальное значение №3 в массиве
MedianValue(array);                 // Медианное значение в массиве
FindMin(array);                     // Минимальное значение в массиве
FindSecondMin(array);               // Минимальное значение №2 в массиве 
FindThirdMin(array);                // Минимальное значение №3 в массиве
InBinary(2);                        // Перевод числа в двоичную сист-му
ReversArray(array);                 // Переворот массива
ReversArrayNewArray(array);         // Переворот массива и запись в новый массив
ProductPairsNum(array);             // Произведение пар чисел (первое-последнее, второе-прдпоследние и т.д.)
FindPrimaryNum(array);              // Простые числа в массиве
GetArray(5, 1, 11);                 // Создание массива и заполнение его случайными числами в указ. диапозоне
MeanValue(array);                   // Среднее значение элементов массива
SumAllElements(array);              // Сумма всех элементов массива
//GetNumbers();                       // Считывание чисел с консоли, перевод их в int и запись в массив
FibonscciPositive(5, 0, 1);         // Числа Фибоначчи в положительном диапозоне
FibonscciNegative(10, 1, -1);       // Числа Фибоначчи в отрицательном диапозоне

int FindMin(int[] arr)                            //  Минимальное значение в ячейке массива
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

int FindSecondMin(int[] arr)                      // 2-е минимальное значение в ячейке массива НЕ ИЗМЕНЯЯ ЕГО
{
    int min = arr[0];
    int min2 = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    if (min == arr[0]) min2 = arr[1];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min2 && arr[i] != min) min2 = arr[i];
    }
    return min2;
}

int FindThirdMin(int[] arr)                       //  3-е минимальное значение в ячейке массива НЕ ИЗМЕНЯЯ ЕГО
{
    int min = arr[0];
    int min2 = arr[0];
    int min3 = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    if (min == arr[0]) min2 = arr[1];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min2 && arr[i] != min) min2 = arr[i];
    }
    if (min == arr[0] | min2 == arr[0])
    {
        min3 = arr[1];
        if (min == arr[1] | min2 == arr[1])
        {
            min3 = arr[2];
        }
    }
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min3 && arr[i] != min)
        {
            if (arr[i] != min2) min3 = arr[i];
        }
    }
    return min3;
}

int FindMax(int[] arr)                            // Максимальное значение в массиве
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

int FindSecondMax(int[] arr)                      // 2-е максимальное значение в массиве
{
    int max = arr[0];
    int max2 = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    if (max == arr[0]) max2 = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max2 && arr[i] != max) max2 = arr[i];
    }
    return max2;
}

int FindThirdMax(int[] arr)                       // 3-е максимальное значение в массиве
{
    int max = arr[0];
    int max2 = arr[0];
    int max3 = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    if (max == arr[0]) max2 = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max2 && arr[i] != max)
        {
            max2 = arr[i];
        }
    }
    if (max == arr[0] | max2 == arr[0])
    {
        max3 = arr[1];
        if (max == arr[1] | max2 == arr[1])
        {

            max3 = arr[2]; ;
        }
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max3)
        {
            if (arr[i] != max && arr[i] != max2)
            {
                max3 = arr[i];
            }
        }
    }
    return max3;
}

int PositiveNumCount(int[] arr)                   // Количество положительных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int NegativeNumCount(int[] arr)                   // Количество отрицательных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) count++;
    }
    return count;
}

int OddNumCount(int[] arr)                        // Колличество нечетных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0) count++;
    }
    return count;
}

int EvenNumCount(int[] arr)                       // Колличество четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0 & arr[i] != 0) count++;
    }
    return count;
}

string FindPrimaryNum(int[] arr)                  // Найти простые числа в массиве (Простое число - число которое делится без остатка только на себя и на 1) Пример до 100: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97
{
    String result = "";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0 & Math.Sqrt(arr[i]) / 10 != 0) result += arr[i] + " ";
    }
    return result;
}

string FindPerfectSquares(int[] arr)              // Найти полностью квадратные числа в массиве (Полный квадрат число, являющееся квадратом некоторого целого числа. Иными словами, квадратом является целое число, квадратный корень из которого извлекается нацело.) Например: 4, 9, 16, 25, 36
{
    String result = "";
    for (int i = 0; i < arr.Length; i++)
    {
        int temp = 0;
        if (arr[i] < 0)
        {
            arr[i] = arr[i] * -1;
            temp = (int)Math.Sqrt(arr[i]);
            if (temp * temp == arr[i]) result += "-" + arr[i] + " ";
            arr[i] = arr[i] * -1;
        }
        else
        {
            temp = (int)Math.Sqrt(arr[i]);
        }
        if (temp * temp == arr[i]) result += arr[i] + " ";
    }
    return result;
}

string FindPerfectCubes(int[] arr)                // Найти полностью кубические числа в массиве (Идеальный куб - это число, которое получается путем трехкратного умножения одного и того же целого числа.) Например: 1, 8, 27, 64
{
    String result = "";
    for (int i = 0; i < arr.Length; i++)
    {
        int temp = 0;
        if (arr[i] < 0)
        {
            arr[i] = arr[i] * -1;
            temp = (int)Math.Cbrt(arr[i]);
            if (temp * temp * temp == arr[i]) result += "-" + arr[i] + " ";
            arr[i] = arr[i] * -1;
        }
        else
        {
            temp = (int)Math.Cbrt(arr[i]);
        }
        if (temp * temp * temp == arr[i]) result += arr[i] + " ";
    }
    return result;
}

int SumAllElements(int[] arr)                     // Сумма всех элементов массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

int MeanValue(int[] arr)                          // Среднее значение элемнтов массива
{
    int mean = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        mean += arr[i];
    }
    return mean / arr.Length;
}


/*  Медиана - это "середина" отсортированного списка чисел, если кол-во чисел четно, то вычисляется
    среднее арефметичиское двух чисел по серидине
    Пример для нечетного кол-ва чисел: 3, 5, 7, 12, 13, 14, 21, 23, 23, 23, 23, 29, 39, 40, 56
                        Медиана равна:                          23
    Для четного кол-ва чисел: 3, 5, 7, 12, 13, 14, 21, 23, 23, 23, 23, 29, 40, 56
               Медиана равна:                      (21+23)/2 = 22
*/
static int MedianValue(int[] arr)                 // Медианное значение 
{
    int[] arr2 = arr;
    int median = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        for (int j = i + 1; j < arr2.Length; j++)
        {
            int temp = 0;
            if (arr2[j] < arr[i])
            {
                temp = arr2[i];
                arr2[i] = arr2[j];
                arr2[j] = temp;
            }
        }
    }
    if (arr2.Length % 2 == 0)
    {
        median = arr2[(arr2.Length - 1) / 2] + arr2[arr2.Length / 2];
    }
    else
    {
        median = arr2[arr2.Length / 2];
    }
    return median;
}

void PrintArray(int[] arr)                          // Вывести массив в консоль
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
    Console.WriteLine();
}

int[] FibonscciPositive(int fn, int f1, int f2)   // Числа Фибоначчи в положительном диапозоне
{
    int[] fib = new int[fn];
    fib[0] = f1;
    fib[1] = f2;
    for (int i = 2; i < fib.Length; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return fib;
}

int[] FibonscciNegative(int fn, int f1, int f2)   // Числа Фибоначчи в отрицательном диапозоне [-10, 1, -1]
{
    int[] fib = new int[fn];
    fib[0] = f1;
    fib[1] = f2;
    for (int i = 2; i < fib.Length; i++)
    {
        fib[i] = fib[i - 2] - fib[i - 1];
    }
    return fib;
}

int[] CopyArray(int[] arr)                       // Копирование массива
{
    int[] array = new int[arr.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

int[] GetArray(int sizeArray, int minValue, int maxValue) // Создание массива и заполнение его случайными числами в указ. диапозоне
{
    int[] arr = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

int[] InBinary(int num)                             // Перевод числа в двоич. сист-му с записью его значения в массив
{
    int count = 0;                                      //
    int temp = num;
    while (temp > 0)
    {                                                   //  Для выяснения длины необходимого массива
        temp /= 2;
        count++;
    }                                                   //
    int[] binary = new int[count];
    for (int i = binary.Length - 1; i >= 0; i--)
    {
        binary[i] = num % 2;
        num /= 2;
    }
    return binary;
}

void ReversArray(int[] arr)                       // Переворот массива
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] ReversArrayNewArray(int[] arr)             // Переворот массива и запись в новый массив
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[arr.Length - 1 - i];
    }
    return result;
}

int[] GetNumbers()                                  // Считывание чисел с консоли, перевод их в int и запись в массив
{
    Console.Write("Введите числа через запятую: ");
    int[] array = Console.ReadLine()                                            // Полчаем данные введенные через терминал
        .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)     // Разбиваем строку на подстроки по символу "," исключая случайные пробелы
        .Select(b => int.Parse(b))                                              // Преобразовываем String-овые значения полученных подстрок в тип int 
        .ToArray();                                                             // Присваеваем полученные значения в массив
    return array;
}

int[] ProductPairsNum(int[] arr)                    // Произведение пар чисел (первое-последнее, второе-предпоследне и т.д.)
{
    int length = 0;
    if (arr.Length % 2 == 0)
    {
        length = arr.Length / 2;
    }
    else
    {
        length = arr.Length / 2 + 1;
    }
    int[] array = new int[length];
    if (arr.Length % 2 == 0)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            array[i] = arr[i] * arr[arr.Length - 1 - i];
        }
    }
    else
    {
        for (int i = 0; i <= arr.Length / 2; i++)
        {
            if (i == arr.Length / 2)
            {
                array[i] = arr[arr.Length / 2];
            }
            else
            {
                array[i] = arr[i] * arr[arr.Length - 1 - i];
            }
        }
    }
    return array;
}

int FindNumsRange (int [] arr, int minValue, int maxValue)  // Найти кол-во чисел в указаном диапозоне
{
    int count = 0;
    for (int i = 0; i<arr.Length; i++){
        if (arr[i]>=minValue & arr[i]<=maxValue){
            Console.WriteLine(arr[i]);
            count++;
        }
    }
    return count;
}

bool FindNumArray (int [] arr, int num)             // Есть-ли заданное число в массиве
{
    bool result = false;
    if(num<0){
        num*=-1;
    }
    for(int i = 0; i<arr.Length; i++){
        if (arr[i] < 0){
            arr[i] *= -1;
        }
        if(arr[i] == num){
            result = true;
        }
    }
    return result;
}

