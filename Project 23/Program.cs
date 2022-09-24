// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели(1-7)");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 8) if (number == 6 || number == 7) Console.WriteLine("да");
                else Console.WriteLine("нет");
else Console.WriteLine("Ввели некорректное число");
   