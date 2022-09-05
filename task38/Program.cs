Console.Clear();
System.Console.WriteLine("Введите количество элементов массива ");
int [] rand = new int[int.Parse(Console.ReadLine())];
for (int i = 0; i < rand.Length; i++)
{
    rand[i] = new Random().Next(2, 99);
    System.Console.Write(rand[i]+ " ");
}
System.Console.WriteLine();
System.Console.WriteLine("Разница между максимальным и минимальным элементом " + (rand.Max() - rand.Min()));