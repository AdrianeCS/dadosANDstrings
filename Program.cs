Console.WriteLine("--- Primero Caractere ---");

Console.Write("Digite algo...: ");
string texto = Console.ReadLine()!;

Console.WriteLine(texto.Trim().Substring(0, 1));

