// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите натуральное число:");
int number = int.Parse(Console.ReadLine());
int count = 1;
int index = 1;
while (count < number * number * number)
{
    Console.Write($"{count}, ");
    count = (index + 1) * (index + 1) * (index + 1);
    index = index + 1;
}
Console.Write(count);