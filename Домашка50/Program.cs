 int m = Propmt("Введите количество строк");
 int n = Propmt("Введите количество столбцов");
 int Propmt(string message) {
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;

}

int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
  int a = Propmt("Введите координаты масива Х");
 int b = Propmt("Введите координаты масива У");
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }
