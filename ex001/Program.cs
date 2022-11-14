// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
    Console.WriteLine("два числа равны");
else if (number1 < number2)
    Console.WriteLine("первое число меньше второго");
else if (number1 > number2)
    Console.WriteLine("первое число больше второго");
Console.ReadKey();