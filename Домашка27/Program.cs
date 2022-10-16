Console.WriteLine("Введите число ");
string number1 = Console.ReadLine();
int n = int.Parse(number1);

int result = 0;
int f =0;

int NumberLen = number1.Length;

void Summ(int n) {
    for(int i=0;i<NumberLen;i++) {
        f=n%10;
        n=n/10;
        result=result+f;
    }
    Console.WriteLine(result);
}

Summ(n);