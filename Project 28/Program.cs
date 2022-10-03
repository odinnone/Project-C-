// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите два числа(A и B)");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int r = 1;
if (b > 0) {
    for (int i = 0; i < b; i++) r = r*a;
    Console.WriteLine($"Число А в степени В - {r}");
}
else Console.WriteLine("Ввели не натуральное число В"); 