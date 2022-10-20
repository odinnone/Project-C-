int number = new Random().Next(10, 100);
int firstDigit = number / 10;
int secondDigit = number % 10;
Console.WriteLine(number);
if (secondDigit == firstDigit) Console.WriteLine("Цифры одинаковые");
else if (firstDigit > secondDigit) Console.WriteLine(firstDigit);
     else Console.WriteLine(secondDigit);