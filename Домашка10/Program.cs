Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);
if(a > 99 && a < 1000) {
Console.WriteLine("вторая цифра этого числа " + a1[1]);}
else{
   Console.WriteLine("введите трехзначное число");
}

