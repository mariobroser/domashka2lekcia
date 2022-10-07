
Console.WriteLine("Задача 13 ");
Console.Write("Введи трёхзначное число: ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);
if(a > 99 && a < 1000) {
Console.WriteLine("вторая цифра этого числа " + a1[1]);}
if(a <= 99 && a >=10) {
   Console.WriteLine("третьей цифры нет");
}
