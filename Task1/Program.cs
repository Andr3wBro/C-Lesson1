// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число : ");
string number1 = Console.ReadLine();
Console.Write("Введите второе число : ");
string number2 = Console.ReadLine();
int numberInt1 = int.Parse(number1);
int numberInt2 = int.Parse(number2);
int max=0, min=0;
    if (numberInt1>numberInt2)
    {
        max=numberInt1;
        min=numberInt2;
        Console.WriteLine($"Первое число больше и равно : {max}\nВторое число меньше и равно {min}");
    }
    else
    {
        max=numberInt2;
        min=numberInt1;
        Console.WriteLine($"Второе число больше и равно : {max}\nПервое число меньше и равно : {min}");
    }