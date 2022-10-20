Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int y = x * -1;
for (int i = y; i < x+1; i++) {
    Console.Write(i);
}