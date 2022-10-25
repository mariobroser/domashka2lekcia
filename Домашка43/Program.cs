double b1 = InputValue("Введите b1");
double k1 = InputValue("Введите k1");
double b2 = InputValue("Введите b2");
double k2 = InputValue("Введите k2");
double x=0;
double b=0;
double k=0;

double InputValue(string message) {
    Console.WriteLine(message);
    string value = Console.ReadLine();
    double a = double.Parse(value);
    return a;
}

void Function(double a, double b, double c, double d) {
            b= b2 -b1;
            k=k2-k1;
            x=b/k;
            Console.WriteLine($"точка пересечения двух прямых: = ({x};{x})");
    }

Function(b1,k1,b2,k2);
