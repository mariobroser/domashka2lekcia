Console.WriteLine("Задача 21 ");

int x1 = PrintAndGetValue("Введите Х1");
int y1 = PrintAndGetValue("Введите Y1");
int z1 = PrintAndGetValue("Введите Z1");

int x2 = PrintAndGetValue("Введите Х2");
int y2 = PrintAndGetValue("Введите Y2");
int z2 = PrintAndGetValue("Введите Z2");

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

    double result = Math.Sqrt(Math.Pow(x1 - x2, 2)+Math.Pow(y1 - y2, 2)+Math.Pow(z1 - z2, 2));
    Console.WriteLine("Расстояние между точками в 3D пространстве - " + result);


