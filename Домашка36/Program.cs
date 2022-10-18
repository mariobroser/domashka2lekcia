Console.WriteLine("Введите количество чисел в массиве ");
int n = int.Parse(Console.ReadLine());
Random mySluchainoeChislo = new Random();
int[] massiv = new int[n];
int sum = 0;

void FunctionShow(int n) {
    for(int i =0; i<massiv.Length;i++){
        massiv[i] = mySluchainoeChislo.Next(1,99);
        Console.Write(massiv[i] + " ");
              
    }
}

void FunctionSumm(int sum) {
    for(int i =0; i<massiv.Length; i= i+2) {
        
            sum = sum + massiv[i];
            
        }
        
    Console.WriteLine("Сумма чисел стоящих на нечётных позициях. - " + sum);

}
FunctionShow(n);
Console.WriteLine();
FunctionSumm(sum);