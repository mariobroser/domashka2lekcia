int Prompt(string message) {
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

 int m = Prompt("Ввод m: ");
 int n = Prompt("Ввод n: ");
 int temp = m;

 void PrintSum(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     PrintSum(m, n - 1, sum);

 }


 if (m > n)
 {
     m = n;
     n = temp;
 }
 
 Console.Write($"Сумма натуральных чисел от " + $"{m} до  {n} =");
 PrintSum(m, n, temp = 0);