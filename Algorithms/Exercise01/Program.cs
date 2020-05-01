using System;

//1 – Desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.
namespace Exercise01
{
	class Program
	{
		static void Main(string[] args)
		{
			int NumeroDigitado;

			Console.Write("Insira um numero: "); //Exibe a mensagem

			NumeroDigitado = Convert.ToInt32(Console.ReadLine()); //Lê e converte para int o numero informado

			if (NumeroDigitado % 2 == 0)
			{
				//Número Par
				Console.WriteLine("Par");
			}
			else
			{
				//Numero Impar
				Console.WriteLine("Impar");
			}

			Console.WriteLine(NumeroDigitado.ToString());

			Console.ReadKey();

		}
	}
}
