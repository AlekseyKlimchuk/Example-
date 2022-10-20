Console.WriteLine("Программа нахождения наибольшего числа");
Console.WriteLine("Введите первое числов");
int number_1 = int.Parse(Console.ReadLine ()!);
Console.WriteLine("Введите второе числов");
int number_2 = int.Parse(Console.ReadLine ()!);
int max = number_1;

if (number_1 > max) max = number_1;
if (number_2 > max) max = number_2;

Console.Write("Наибольшее число  ");
Console.WriteLine (max);