double milhas, km;
Console.Write("Digite a medida em milhas: ");
milhas = double.Parse(Console.ReadLine()!);
km = 1.609 * milhas;

Console.WriteLine($"A sua medida em km é {km}");