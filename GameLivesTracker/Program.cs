Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("                     CONTROLE DE VIDAS DO JOGO");
Console.ResetColor();
Console.WriteLine();


Console.Write(" Digite a quantidade de vidas iniciais: ");
int lives = int.Parse(Console.ReadLine()!);

Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("   \nOps! Você errou e perdeu 1 vida.");
lives--;
Console.ResetColor();

Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("   \nBoa! Você acertou e ganhou 1 vida.");
lives++;
Console.ResetColor();

Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("   \nBoa! Você acertou e ganhou 1 vida.");
lives++;
Console.ResetColor();

Thread.Sleep(3000);
Console.WriteLine($" \nVidas finais: {lives}".ToUpper());
