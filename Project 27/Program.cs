// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1) for (int i = 1; i <= n; i++) Console.Write($"{i*i*i} ");
else Console.WriteLine("Ввели некорректное число");