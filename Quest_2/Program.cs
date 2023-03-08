// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее;

Console.WriteLine("Введите первое целое число");

int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе целое число");

int B = int.Parse(Console.ReadLine()!);

if (A > B) Console.WriteLine($"Число {A} больше числа {B}");

else Console.WriteLine($"Число {B} больше числа {A}");