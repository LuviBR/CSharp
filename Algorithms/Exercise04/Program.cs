using System;
//4 – Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário, se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.
namespace Exercise04
{
	class Program
	{
		static void Main(string[] args)
		{
			Processar();

			Console.ReadKey();

		}

		private static void Processar()
		{
			{
				int Idade;
				Console.Write("Informe a sua idade: ");
				int.TryParse(Console.ReadLine(), out Idade);

				if(Idade >= 18)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Acesso permitido");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Acesso Negado");
				}

			}
		}
	}
}
