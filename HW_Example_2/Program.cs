Console.WriteLine("Программа нахождения наибольшего числа");
Console.WriteLine("Введите первое число");
int number_1 = int.Parse(Console.ReadLine ()!);
Console.WriteLine("Введите второе число");
int number_2 = int.Parse(Console.ReadLine ()!);
int max = number_1;
int min = number_1;

if (number_1 == number_2)
            {
                Console.WriteLine("Числа равны");
 
            }
if (number_1 > max) max = number_1;
if (number_2 > max) max = number_2;
if (number_1 > max) min = number_1;
if (number_2 > max) min = number_2;
          
Console.Write("Наибольшее число  ");
Console.WriteLine (max);
Console.Write("Наименьшее число  ");
Console.WriteLine (min);