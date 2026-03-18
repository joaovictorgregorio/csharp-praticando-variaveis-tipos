Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("                     CALCULADORA DE ÁREA E PERÍMETRO");
Console.ResetColor();
Console.WriteLine();


double PI = 3.14159;

Console.Write("   Qual o raio do círculo? ");
double radiusCircle = double.Parse(Console.ReadLine()!);

double areaCircle = PI * radiusCircle * radiusCircle;
double perimeterCircle  = 2 * PI * radiusCircle;

Console.WriteLine($"  \nRaio: {radiusCircle.ToString("F2")}  \nÁrea do círculo: {areaCircle.ToString("F2")}  \nPerímetro do círculo: {perimeterCircle.ToString("F2")}");