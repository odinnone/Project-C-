// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x > y) {
    Console.Write($"max = {x}, min = {y}");
}
else {
    Console.Write($"max = {y}, min = {x}");
}