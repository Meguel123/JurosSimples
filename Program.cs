﻿double j, m, c, i, t;
Console.WriteLine("Escreva seu capital");
c = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Escreva seu taxa de juros");
i = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Escreva seu tempo");
t = Convert.ToDouble(Console.ReadLine()!);

j = c * i /100 * t;

m = c + j;

Console.WriteLine(@$"Seu montante é {m} e seu juros é {j}");