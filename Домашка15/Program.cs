
Console.WriteLine("Задача 15 ");
Console.Write("Введи день недели: ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);
if(a > 0 && a < 6) {
Console.WriteLine("это будни день");}

if(a > 5 && a < 8) {
   Console.WriteLine("это выходной день");
}
if(a > 7 || a < 1)  {
    Console.WriteLine("такого дня недели нет");
};
