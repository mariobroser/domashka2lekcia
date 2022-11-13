int Prompt(string message) {
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int x = Prompt("Введите X");
int y = Prompt("Введите Y");
int z = Prompt("Введите Z");

void PrintArray(int[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    { for (int j = 0; j < array.GetLength(1); j++)
        {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write($"{array[i,j,k]}({i},{j},{k}); ");
      }
      Console.WriteLine();
        
        }
            Console.WriteLine();
    }
}


void CreateArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(1, 10);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(1, 100);
          j = 0;
          number = temp[i];
          
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temp[count];
        
        count++;
      }
    }
  }
}


int[,,] array = new int[x, y, z];
CreateArray(array);
PrintArray(array);
