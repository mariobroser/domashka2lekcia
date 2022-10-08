Console.WriteLine("Задача 19 ");
Console.Write("Введи пятизначное число: ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);


if(a > 0) {
if(a >= 10000 && a <= 99999) {
    
    if (a1[0] == a1[4] && a1[1] == a1[3]) {
    Console.WriteLine(a + " - это число являеться полиндромом");}
    else {
        Console.WriteLine(a + " - это число не являеться полиндромом");
    }
}
else {
   Console.WriteLine("введите пятизначное число");
}

}
else {Console.WriteLine("Error");}

