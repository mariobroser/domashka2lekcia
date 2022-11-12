int Propmt(string message) {
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;

}

bool IsInputLenghtValid(int number) {
    if(number<=0)
    return false;
    return true;

}

int[,] CreatArray(int n, int m, int min, int max){
    int[,] a = new int[n, m];
    for(int row=0;row<n;row++) {
        for(int col=0; col<m; col++){
            a[row,col] = new Random().Next(min, max+1); 

        }
    }
    return a;
}

void PrintArray(int[,] array) {
        for(int row=0;row<array.GetLength(0);row++){
             for(int col=0; col<array.GetLength(1); col++) {
                Console.Write(array[row, col] + " ");
             }
             Console.WriteLine();

        }
    }



void sort(int[,]  array)
{int sum = SumLineElements(array, 0);
    int index =0;
    for(int row = 0; row < array.GetLength(0); row++){
        int temp = 0;
        
        
      for (int col = 0; col < array.GetLength(1); col++){
                    
                    temp = array[row, col] + temp;
                }
                if (temp < sum)
                {
                    sum = temp;
                    index = row;
                }
      }
      Console.WriteLine("Строка: " + index + " Сумма - " + sum);
      
        
}
int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}





 int n = Propmt("Введите количество строк");
 int m = Propmt("Введите количество столбцов");

int[,] array = CreatArray(n, m, 0, 10);
PrintArray(array);
Console.WriteLine();
sort(array);


