Console.WriteLine("Введит числа через запятую ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = 0;


for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }


}
Console.WriteLine("Числа которые вы ввели = " + String.Join(" ", array));
Console.WriteLine($"Кол-во элементов > 0: {count}");
