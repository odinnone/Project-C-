// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Mассив: ");
PrintArray(numbers);
double min = numbers[0];
double max = numbers[0];
for (int j = 1; j < size; j++) {
    if (numbers[j] > max) max = numbers[j];
    if (numbers[j] < min) min = numbers[j];
}
Console.WriteLine($"Разница между максимальным и минимальным значением - {max - min}");

void FillArrayRandomNumbers(double[] numbers) {
    for(int i = 0; i < numbers.Length; i++) numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
}

void PrintArray(double[] numbers) {
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++) Console.Write(numbers[i] + " ");
    Console.Write("]");
    Console.WriteLine();
}