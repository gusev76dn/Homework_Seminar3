// задача 23

int Number(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}
int number = Number ("Введите число: ");

for (int i = 1; i <= number; i++)
{
    double result = Math.Pow(i, 3);
    Console.WriteLine(result + ",");
    Console.Write(result);
}
