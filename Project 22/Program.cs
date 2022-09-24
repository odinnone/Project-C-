// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99) {
    int digit = number / 100;
    int result = digit % 10;
    Console.WriteLine(result);
}
else Console.WriteLine("Третьей цифры нет");