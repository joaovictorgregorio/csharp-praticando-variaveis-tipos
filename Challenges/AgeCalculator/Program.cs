Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("                     CALCULANDO A IDADE");
Console.ResetColor();
Console.WriteLine();


int yearOfBirth = 1997;
int currentYear = DateTime.Now.Year;

int personAge = currentYear - yearOfBirth;

Console.WriteLine($"Sua idade é: {personAge} anos");