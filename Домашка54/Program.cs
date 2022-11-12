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
{
    for(int i = 0; i < array.GetLength(0); i++){
      for (int j = 0; j < array.GetLength(1); j++){
        for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
      }
        
}
}




 int n = Propmt("Введите количество строк");
 int m = Propmt("Введите количество столбцов");

int[,] array = CreatArray(n, m, 0, 10);
PrintArray(array);
Console.WriteLine();
sort(array);
Console.WriteLine();
PrintArray(array);

