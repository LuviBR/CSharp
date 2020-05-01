using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7 – Desenvolva um algoritmo que calcule o reajuste salarial. Se o salário for abaixo de 1.700 o ajuste é de R$300.00, 
 se maior de R$ 200.00. Para finalizar, exiba o novo salário na tela.*/
namespace Exercise07
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			Double Salario;

			Console.WriteLine("Informe o seu salário, use ponto");
			Console.Write("Salário: ");
			double.TryParse(Console.ReadLine(), out Salario);

			Console.WriteLine();

			Console.WriteLine("Salario atual: ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(Salario.ToString());

			Console.ResetColor();
			Console.WriteLine();

			Console.WriteLine("\a");

			Console.Write("Novo salario: ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(p.CalculaSalario(Salario));

			Console.ReadKey();
		}


		private double CalculaSalario(double Salario)
		{
			double NovoSalario = 0;

			if(Salario >= 1700)
			{
				NovoSalario = (Salario + 200);
			}
			else
			{
				NovoSalario = (Salario + 300);
			}

			return NovoSalario;
		}
	}
}
