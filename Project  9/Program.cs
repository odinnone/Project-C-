Console.WriteLine("Введите два числа");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (y * y == x) {
    Console.WriteLine($"Число {x} является квадратом числа {y}");
}
else {
    Console.WriteLine($"Число {x} не является квадратом числа {y}");
}