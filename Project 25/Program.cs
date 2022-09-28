// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
string str = Console.ReadLine();
int length = str.Length;
int count = 0;
if (length == 5) {
    for (int i = 0; i < length / 2; i++) {
        if (str[i] == str[length - i - 1]) count++;
    }
    if (count == length / 2) Console.WriteLine("палиндром");
    else Console.WriteLine("не палиндром");
}
else Console.WriteLine("Ввели не пятизначное число");