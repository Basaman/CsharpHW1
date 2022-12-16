//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 ->  max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число 1: ");
string userInput_A = Console.ReadLine() ?? "";
Console.Write("Введите число 2: ");
string userInput_B = Console.ReadLine() ?? "";

double numberA = double.Parse(userInput_A);
double numberB = double.Parse(userInput_B);
double max = double.Parse(userInput_A);
double min = double.Parse(userInput_B);

if (numberB > max)
{
    max = numberB;
    min = numberA;
}
else
{
    max = numberA;
    min = numberB;
}
if (numberA == numberB)
{
    Console.WriteLine("Невозможно определить максимальное и минимальное число, так как числа равны ");
}
else
{
Console.WriteLine("Максимальным из двух числел является: ");
Console.WriteLine(max);
Console.WriteLine("Минимальным из двух числел является: ");
Console.WriteLine(min);
}
