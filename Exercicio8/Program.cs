﻿double n1, n2, result;
Console.Write("Digite o primeiro valor desejado: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor desejado: ");
n2 = double.Parse(Console.ReadLine());
result = n1 - n2;
Console.WriteLine($"O resultado da subtração é: {result}");

if (result >= 0)
{
    Console.WriteLine("TOTAL NEGATIVO");
}
else
{
    Console.WriteLine("TOTAL POSITIVO");
}
