Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("                     CALCULADORA ÁREA DO RETÂNGULO");
Console.ResetColor();
Console.WriteLine();


Console.Write(" Qual é a largura do retângulo? ");
double width = double.Parse(Console.ReadLine()!);

Console.Write(" Qual é o comprimento do retângulo? ");
double length = double.Parse(Console.ReadLine()!);

double area = (width * length) / 100.0;

Console.WriteLine($" \nA área do terreno é: {area} m².");