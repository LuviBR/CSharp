using System;

//2 – Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.
namespace Exercise02
{
	class Program
	{
		static void Main(string[] args)
		{
			string Nome; //Variável que armazena o nome do Usuário
			Console.Write("Informe o seu nome: ");
			Nome = Console.ReadLine();

			Console.WriteLine("");
			Console.WriteLine("");

			Console.WriteLine("Meu nome é: ");

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(Nome);

			Console.ReadKey();

		}
	}
}
