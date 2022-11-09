 int n = Propmt("Введите количество строк");
 int m = Propmt("Введите количество столбцов");

int Propmt(string message) {
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;

}


double[,] Array = new double[m, n];
Random rnd = new Random();

void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToDouble(rnd.Next(1, 10000)/100.0);}}}


FillArray(Array);
Console.WriteLine();
PrintArray(Array);