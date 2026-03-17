Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("                     CONVERSÃO DE TIPOS");
Console.ResetColor();
Console.WriteLine();

Console.Write("Informe o peso total em toneladas: ");
decimal containerWeight = decimal.Parse(Console.ReadLine()!);

Console.WriteLine($"Veículos necessários: {(int)containerWeight}");