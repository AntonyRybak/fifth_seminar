Console.Clear();
System.Console.WriteLine("Введите количество элементов массива ");
int [] rand = new int[int.Parse(Console.ReadLine())];
int sum = 0;
for (int i = 0; i < rand.Length; i++)
{
    rand[i] = new Random().Next(-99, 99);
    System.Console.Write(rand[i]+ " ");
}
for (int i = 1; i < rand.Length; i += 2){
    sum += rand[i];
}
System.Console.WriteLine();
System.Console.WriteLine(sum);