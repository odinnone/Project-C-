// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Mассив: ");
PrintArray(numbers);
int result = 0;
for (int j = 1; j < size; j+=2) result = result + numbers[j];
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях - " + result);

void FillArrayRandomNumbers(int[] numbers) {
    for(int i = 0; i < numbers.Length; i++) numbers[i] = new Random().Next(-100,100);
}

void PrintArray(int[] numbers) {
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++) Console.Write(numbers[i] + " ");
    Console.Write("]");
    Console.WriteLine();
}