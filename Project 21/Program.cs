// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000) {
    int digit = number / 10;
    int result = digit % 10;
    Console.WriteLine(result);
}
else Console.WriteLine("Введено не трехзначное число");