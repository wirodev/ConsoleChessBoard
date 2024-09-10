using System;
//"□ "
//"■ "

namespace ConsoleChessBoard
{
	class ChessBoard
	{
		static void Main()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8; //Obs! Du kan behöva kopiera in denna kodrad i början av ditt program för att få tecknen att visas korrekt

			Console.Write("Skriv in en siffra: ");
			string? number = Console.ReadLine(); // ? tillåt null

            if (Int32.TryParse(number, out int chessCount)) // TryParse är mer säkert och enklare för att hantera felaktig inmatning än Int32.Parse()
            {
				for (int i = 0; i < chessCount; i++)// loopa genom rader
				{
					for (int a = 0; a < chessCount; a++)// loopar genom kolumner
					{
						if ((i + a) % 2 == 0)// kontrollera jämna eller udda tal
						{
							Console.Write("■ ");// jämna tal visar fylld
						}
						else
						{
							Console.Write("□ ");// udda visar ihålig
						}
					}
					Console.WriteLine();// för att hoppa till ny rad efter varje iterering
				}
			}
            else
            {
                Console.WriteLine("Fel uppstod, prova igen.");
            }
		}
	}
}
