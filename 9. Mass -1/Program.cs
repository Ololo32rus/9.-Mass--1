// Дан массив, убрать все повторяющиеся элементы, т.е. вывод на -1 

int Count;
int a;
int b;
int c;

Random random = new Random();

Console.Write("$ Введите любое число от 5 до 15 ");
Count = int.Parse(Console.ReadLine());

int[] mas = new int[Count];
mas[Count] = random.Next(1, 5 + 1);

Console.WriteLine($"Массив который срандомился : {mas}");

    for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(1, 5 + 1);
    a = mas[i];

    for (b = i + 1; b < mas.Length; b++)   // тут скорее не b , потому что b в данном случае числовое значение индекса
        if (mas[b] == a)
        {
            mas[b] = -1;
        }
    Console.WriteLine($"{mas.Length}");
}




Console.ReadKey();

