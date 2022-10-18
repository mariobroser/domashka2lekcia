Console.WriteLine("Введите количество чисел в массиве ");
int n = int.Parse(Console.ReadLine());
Random mySluchainoeChislo = new Random();
int[] massiv = new int[n];
int count = 0;

void FunctionShow(int n) {
    for(int i =0; i<massiv.Length;i++){
        massiv[i] = mySluchainoeChislo.Next(100,999);
        Console.Write(massiv[i] + " ");
              
    }
}

void FunctionCount(int count) {
    for(int i =0; i<massiv.Length;i++) {
        if(massiv[i]%2 == 0) {
            count = count + 1;
            
        }
        else{count = count;}
    }
    Console.WriteLine("Количество четных чисел в массиве - " + count);

}
FunctionShow(n);
Console.WriteLine();
FunctionCount(count);