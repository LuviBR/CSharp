using System;
//5 – Desenvolva um método que receba por parâmetro o um nome, e retorne a frase “Olá meu nome é: {nome recebido}”.
namespace Exercise05
{
	class Program
	{
		static void Main(string[] args)
		{
			string Nome;
			Console.WriteLine("Informe o seu nome: ");

			Nome = Console.ReadLine();

			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Blue;

			Console.WriteLine(string.Format("Meu nome é: {0}", Nome));

			Console.ReadKey();

		}
	}
}
