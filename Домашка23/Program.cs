Console.WriteLine("Задача 23 ");
int PrintNumber(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}

int N = PrintNumber("Введите число");

for(var i=1; i<=N; i+=1) {
    double a = Math.Pow(i, 3);
    if (i < N) {
        Console.Write(a +",");
    }
    else 
    {Console.Write(a+".");}
}
