// задача 21

int NumberXandYandZ(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}
double GetDistance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double result = Math.Sqrt(Math.Pow(x1 - x2, 3) + Math.Pow(y1 - y2, 3) + Math.Pow(z1 - z2, 3));
    return result;
}
int x1 = NumberXandYandZ("Введите координаты отрезка x1: ");
int y1 = NumberXandYandZ("Введите координаты отрезка y1: ");
int z1 = NumberXandYandZ("Введите координаты отрезка z1: ");
int x2 = NumberXandYandZ("Введите координаты отрезка x2: ");
int y2 = NumberXandYandZ("Введите координаты отрезка y2: ");
int z2 = NumberXandYandZ("Введите координаты отрезка z2: ");

Console.WriteLine(GetDistance(x1, y1, z1, x2, y2, z2));