Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("                     MÉDIA DAS NOTAS");
Console.ResetColor();
Console.WriteLine();

Console.Write(" Digite a 1ª nota: ");
float note1 = float.Parse(Console.ReadLine()!);

Console.Write(" Digite a 2ª nota: ");
float note2 = float.Parse(Console.ReadLine()!);

Console.Write(" Digite a 3ª nota: ");
float note3 = float.Parse(Console.ReadLine()!);

float averageGrades = (note1 + note2 + note3) / 3f;

Console.WriteLine($" \nA média das notas é: {averageGrades}");