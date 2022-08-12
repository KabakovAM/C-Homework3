// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X точки А:");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки А:");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки А:");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату X точки В:");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки В:");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки В:");
int z2 = int.Parse(Console.ReadLine());

double Distance3D(int a1, int b1, int c1, int a2, int b2, int c2)
{
    double dis=Math.Round(Math.Sqrt((a2-a1)*(a2-a1)+(b2-b1)*(b2-b1)+(c2-c1)*(c2-c1)),2,MidpointRounding.ToZero);
    return dis;
}

Console.WriteLine($"Растояние между точками A и B равно: {Distance3D(x1, y1, z1, x2, y2, z2)}");