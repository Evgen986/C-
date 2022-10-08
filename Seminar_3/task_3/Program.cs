/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
              и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
Console.Clear();
Console.WriteLine("Введите координату X точки №1: ");
double point1X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки №1: ");
double point1Y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X точки №2: ");
double point2X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки №2: ");
double point2Y = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(point2X-point1X, 2)+Math.Pow(point2Y-point1Y, 2));
Console.WriteLine("Дистанция = " + Math.Round(distance, 2));