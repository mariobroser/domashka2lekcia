Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число ");
int number2 = int.Parse(Console.ReadLine());
int result = 1;

void ShowResult(int number) {
for(int i=1; i<=number2; i++) {
    result = result * number1;
}
Console.WriteLine(result);
}

ShowResult(result);