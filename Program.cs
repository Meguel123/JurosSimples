int j, m, c, i, t;
Console.WriteLine("Escreva seu capital");
c = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Escreva seu taxa de juros");
i = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Escreva seu tempo");
t = Convert.ToInt32(Console.ReadLine()!);

j = c * i * t;

m = c + j;

Console.WriteLine(@$"Seu montante é {m} e seu juros é {j}");