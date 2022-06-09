// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число :");
string number1 = Console.ReadLine();
Console.Write("Введите второе число :");
string number2 = Console.ReadLine();
Console.Write("Введите третье число :");
string number3 = Console.ReadLine();
int numberInt1 = int.Parse(number1);
int numberInt2 = int.Parse(number2);
int numberInt3 = int.Parse(number3);
int max=0;
    if (max<numberInt1)
    {
        max=numberInt1;
    }
    if (max<numberInt2)
    {
        max=numberInt2;
    }
    if (max<numberInt3)
    {
        max=numberInt3;
    }
Console.WriteLine($"Самое больше число : {max}");
