// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());
void NumberSum (int m, int n, int sum) {
    if (m > n) {
        Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    NumberSum(m, n, sum);
}
NumberSum(m, n, 0);