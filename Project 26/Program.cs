// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты двух точек в 3D пространстве");
float x1 = Convert.ToSingle(Console.ReadLine());
float y1 = Convert.ToSingle(Console.ReadLine());
float z1 = Convert.ToSingle(Console.ReadLine());
float x2 = Convert.ToSingle(Console.ReadLine());
float y2 = Convert.ToSingle(Console.ReadLine());
float z2 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine($"A({x1}, {y1}, {z1}), B({x2}, {y2}, {z2})");
double d = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
Console.WriteLine("Расстояние " + d);