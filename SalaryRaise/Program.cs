Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("                     CALCULADORA AUMENTO SALARIAL");
Console.ResetColor();
Console.WriteLine();

Console.Write("   Qual é o seu salário atual? R$ ");
decimal currentSalary = decimal.Parse(Console.ReadLine()!);

Console.Write("   Qual é o percentual de aumento? (%) ");
int percentageIncrease = int.Parse(Console.ReadLine()!);

decimal salaryIncrease = currentSalary + (currentSalary * percentageIncrease / 100);

Console.WriteLine($" \nO novo salário é de {salaryIncrease:C}");