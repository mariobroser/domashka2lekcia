Console.WriteLine("Введите количество чисел в массиве ");
int n = int.Parse(Console.ReadLine());
Random mySluchainoeChislo = new Random();
int[] massiv = new int[n];
int sum = 0;
int max = 1;
int min = 100;




void FunctionShow(int n) {
    for(int i =0; i<massiv.Length;i++){
        massiv[i] = mySluchainoeChislo.Next(1,99);
        Console.Write(massiv[i] + " ");
              
    }
}



 void FunctionResult(int sum) {
    for(int i=0;i<massiv.Length;i++) {
        if(max<massiv[i]) {
            max = massiv[i];
        }
        else{max = max;}
    }
    
    Console.WriteLine("Максимальное число в массиве - " + max);

    for(int i=0;i<massiv.Length;i++) {
        if(min >= massiv[i]) {
            min = massiv[i];
        }
        else{min = min;}
    }
    
    Console.WriteLine("Минимальное число в массиве - " + min);

    sum = max- min;
    Console.WriteLine("Сумма между максимальным и минимальным числом равен - " + sum);

    
 }




  




FunctionShow(n);
Console.WriteLine();
FunctionResult(sum);
Console.WriteLine();









 
 



