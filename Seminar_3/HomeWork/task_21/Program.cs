/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
              A (3,6,8); B (2,1,-7), -> 15.84
              A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

// Предлагаем пользователю ввести координаты точки А;
Console.Write("Введите координату X точки A: ");
double pointAx = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
double pointAy = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
double pointAz = int.Parse(Console.ReadLine());

// Предлагаем пользователю ввести координаты точки В;
Console.Write("Введите координату X точки B: ");
double pointBx = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double pointBy = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
double pointBz = int.Parse(Console.ReadLine());

// По формуле находим расстояние между точками;
double distance = Math.Sqrt(Math.Pow(pointBx-pointAx, 2)+Math.Pow(pointBy-pointAy, 2)+Math.Pow(pointBz-pointAz, 2));

// Выводим пользователю полученное расстояние с округлением до 2-х знаков после запятой;
Console.WriteLine("Расстояние между точками = " + Math.Round(distance, 2));