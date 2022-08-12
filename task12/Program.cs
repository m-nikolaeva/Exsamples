// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// Mth.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2)))

Console.WriteLine("Введите x координату 1 точки: ");
int xa1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y-координату 1 точки: ");
int ya1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x координату 2 точки: ");
int xb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y-координату 2 точки: ");
int yb2 = Convert.ToInt32(Console.ReadLine());


double GetDist(int xa, int ya, int xb, int yb)
{
    double dx = xa - xb;
    double dy = ya - yb;
    return Math.Sqrt(dx * dx + dy * dy);
}

double result = GetDist(xa1, ya1, xb2, yb2);
Console.WriteLine($"A ({xa1}, {ya1}); B ({xb2}, {yb2}) -> {Math.Round(result, 2)}");