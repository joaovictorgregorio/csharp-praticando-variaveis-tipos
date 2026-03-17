Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("                     REGISTRO DE DOAÇÕES");
Console.ResetColor();
Console.WriteLine();


Console.Write("Valor da doação: ");
decimal donation = decimal.Parse(Console.ReadLine()!);

Console.Write("[True ou False] Doação anônima: ");
bool typeOfDonation = bool.Parse(Console.ReadLine()!);

Console.Write("[P ou F] Tipo de conta: ");
char accountType = char.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Valor doado: {donation:C}");
Console.WriteLine($"Doação anônima: {typeOfDonation}");
Console.WriteLine($"Tipo de conta: {accountType}".ToUpper());