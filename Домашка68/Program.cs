int Prompt(string message) {
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}


int Akkerman(int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if (n == 0 && m > 0)
{
return Akkerman(m - 1, 1);
}
else
{
return Akkerman(m - 1, Akkerman(m, n - 1));
}
}

int m = Prompt("Ввод m: ");
int n = Prompt("Ввод n: ");
int akkermanFunction = Akkerman(m, n);

Console.Write($"m = {m}, n = {n} = A(m,n) = {akkermanFunction} ");
    
  