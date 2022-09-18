string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("Введите номер дня недели(1-7)");
int x = Convert.ToInt32(Console.ReadLine());
x--;
if (x <= 7) {
    Console.WriteLine(weekDays[x]);
}
else {
    Console.WriteLine("Ввели некорректное число");
}    