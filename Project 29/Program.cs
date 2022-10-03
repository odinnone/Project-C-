// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
int r = n % 10;
while (n > 9) {
    n = n / 10;
    r = r + n % 10;
}
Console.WriteLine($"Сумма цифр введенного числа - {r}");