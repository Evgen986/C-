﻿/* ПЕРВЫЙ ВАРИАНТ РЕШЕНИЯ
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number2>max){
    max=number2;
}
if (number3>max){
    max=number3;
}
Console.WriteLine("Большее число: " + max);
*/


// ВВОД ЧИСЕЛ В ОДНУ СТРОКУ И ИСПОЛЬЗОВАНИЕ МАССИВА
// Очищаем консоль
Console.Clear();

// Предагаем пользователю ввести числа
Console.Write("Введите три числа, через запятую: ");

// Создаем массив с тремя ячейками для хранения чисел пользователя
int[] array = new int[3], a, b, c;

// Присваеваем в массив числа вводимые в терминале, с помощью метода Split делим строку на символы, которые будут временно хранится в массиве string, 
// используя в качестве разделителя строки ",", с ограничением в три символа, пропуском случайных пробелов, 
// преобразуем хранящиеся в стринговом массиве значения в тип int, НЕ СОВСЕМ ПОНЯЛ - ?? если можно поясните почему в методе Select используется параметр b ??,
//  заранее спасибо! 
array = Console.ReadLine().Split(new string[] { "," }, 3, StringSplitOptions.RemoveEmptyEntries).Select(b => int.Parse(b)).ToArray();

// Создаем целочисленную переменную max и присваеваем ей значение из [0] ячейки массива array
int max = array[0];

// Используем цикл for для перебора массива и сравнения значений в его ячейка с значением пременной max, если значение больше то, оно присваевается в max
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}

// Выводим пользователю максимальное число
Console.WriteLine("Максимальное число = " + max);

