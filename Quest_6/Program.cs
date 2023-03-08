// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка(number%2==0))

Console.WriteLine("Введите число");

int A = int.Parse(Console.ReadLine()!);

if (A%2 == 0) Console.WriteLine("Введеное число - четное");
else Console.WriteLine("Введеное число - нечетное");