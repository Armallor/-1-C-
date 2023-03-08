// Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N

Console.WriteLine("Введите число");

int A = int.Parse(Console.ReadLine()!);

while (A > 1){
if (A%2 == 0) Console.WriteLine(A);
A = A - 1;
}