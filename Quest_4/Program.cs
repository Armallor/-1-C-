// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введите первое целое число");

int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе целое число");

int B = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье целое число");

int C = int.Parse(Console.ReadLine()!);

int MAX = A;

if (B > MAX) MAX = B;

if (C > MAX) MAX = C;

Console.WriteLine($"Максимальное число равно {MAX}");