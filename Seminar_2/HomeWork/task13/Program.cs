﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
// Запрашиваем у пользователя число
Console.Write("Введите Ваше трехзначное число: ");
String number = Console.ReadLine();
// Приводим введенное число из типа String в тип int
int num = int.Parse(number);
//Находим длину строки для введенного числа
int index = number.Length;
// Если введенное число является отрицательным:
//          приводим его в положительный диапозон
//          и кол-во символов в строке уменьшаем на 1, что-бы убрать минус
if(num<0){
    num*=-1;
    index--;
}
// Если кол-во символов в строке меньше 3-х сообщаем пользователю, что он ввел неправильное число
// и прерываем выполнение программы
if(index<3){
Console.WriteLine($"В Вашем числе: {number}, нет третьей цифры!"); 
return;   
}
// Для нахождения третьей цифры возводим 10 в степень уменьшенную на 3, что бы исключить первые числа
double temp = Math.Pow(10, index-3);
// Преобразуем полученное значение 10 в степени в тип int
index = (int)temp;
// По формуле находим 3-ю цифру
num = num/index%10;
// Выводим её пользователю
Console.WriteLine($"Третьей цифрой числа {number} является: {num}");