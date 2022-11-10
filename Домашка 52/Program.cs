 int m = Propmt("Введите количество строк");
 int n = Propmt("Введите количество столбцов");
 int Propmt(string message) {
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;

}


int[,] array = new int[m, n];
 
 void FillArray(int[,] matr) {
for (int row = 0; row < array.GetLength(0); row++) 
{
    for (int col = 0; col < array.GetLength(1); col++)
        array [row, col] = Convert.ToInt32(new Random().Next(0,21));  
}
}


 void PrintArray(int[,] matr)
{ 
for (int row = 0; row < array.GetLength(0); row++) 
{
    for (int col = 0; col < array.GetLength(1); col++)
        Console.Write(array[row,col] + "\t  ");
        Console.WriteLine();
}
}

void Sum(int[,] array) {
    double msumms = 0;
    double[] result = new double[n];
    Console.Write("Средне арифмитическое в столбцах = [");
    
    
    for(int col=0;col<array.GetLength(0);col++){  
        double summs = 0;
        for (int row = 0; row < array.GetLength(1); row++){
                                 
        
               summs = summs + array[row,col];
                msumms = summs / m;
        }
        
                Console.WriteLine($"{Math.Round(msumms,2)};");
        
    }
    Console.Write("]");
    
}

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Sum(array);





 
