Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("                     CONVERSOR MINUTOS PARA HORAS");
Console.ResetColor();
Console.WriteLine();

Console.Write("Digite os minutos que você quer converter em horas e minutos: ");
int minutes = int.Parse(Console.ReadLine()!);

int hours = minutes / 60;
int minutesRemaining = minutes % 60;

Console.WriteLine($"Tempo: {hours} horas e {minutesRemaining} minutos");