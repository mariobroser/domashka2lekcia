int Prompt(string message) {
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int n = Prompt("Введите число");
    
    
    
    String recursion(int n) {
        
        if (n == 1) {
            return "1";
        }
        
        return n + " " + recursion(n - 1);
    }
    

Console.WriteLine(recursion(n));