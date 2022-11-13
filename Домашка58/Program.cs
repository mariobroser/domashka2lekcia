int Prompt(string message) {
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int n = Prompt("Введите количеств строк");
int m = Prompt("Введите количество столбцов");
int p = Prompt("Введите количество столбцов второй матрицы");
int min = 0;
int max = 10;

int[,] CreatArray(int n, int m) {
    int[,] a =new int[n,m];
    for (int row = 0; row < n; row++)
    { for (int col = 0; col < m; col++)
        {a[row,col] = new Random().Next(min, max+1);
        
        }
        
    }
    return a;
}


void PrintArray(int[,] array) {
    for (int row = 0; row < array.GetLength(0); row++)
    { for (int col = 0; col < array.GetLength(1); col++)
        {Console.Write(array[row, col] + " ");
        
        }
            Console.WriteLine();
    }
}

void summArray(int[,] array, int[,] arrayTwo, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array.GetLength(1); k++)
      {
        sum += array[i,k] * arrayTwo[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}


int[,] array = CreatArray(n,m);
int[,] arrayTwo = CreatArray(n,m);
int[,] resultArray = CreatArray(n,p);

PrintArray(array);
Console.WriteLine();
PrintArray(arrayTwo);
Console.WriteLine();
summArray(array, arrayTwo, resultArray);
Console.WriteLine();
PrintArray(resultArray);

