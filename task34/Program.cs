Console.Clear();
System.Console.WriteLine("Введите количество элементов массива ");
int [] rand = new int[int.Parse(Console.ReadLine())];
int count = 0;
for (int i = 0; i < rand.Length; i++)
{
    rand[i] = new Random().Next(101, 1000);
    System.Console.Write(rand[i]+ " ");
}
for ( int i = 0; i < rand.Length; i++){
    if (rand[i] % 2 == 0) count += 1;
}
System.Console.WriteLine();
System.Console.WriteLine("Четных элементов " + count);



