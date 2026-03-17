Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("                     CONVERSOR DE DISTÂNCIA");
Console.ResetColor();
Console.WriteLine();


Console.Write("Digite a distância em milhas para converter em quilômetros: ");
double miles = double.Parse(Console.ReadLine()!);

double kilometers = miles * 1.60934;
Console.WriteLine($"{miles} milhas equivalem a {kilometers} quilômetros.");