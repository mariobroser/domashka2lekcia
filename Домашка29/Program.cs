Console.WriteLine("Введите количество чисел в массиве ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите MAX ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите MIN ");
int min = int.Parse(Console.ReadLine());

Random mySluchainoeChislo = new Random();
int[] massiv = new int[n];

void FunctionShow(int n) {
    for(int i =0; i<massiv.Length;i++){
        massiv[i] = mySluchainoeChislo.Next(min,max);
        Console.Write(massiv[i] + " ");
              
    }
}

FunctionShow(n);