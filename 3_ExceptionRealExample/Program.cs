using System;
using System.Collections.Generic;

namespace _3_ExceptionRealExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Oi de novo!");
			Console.WriteLine("Dessa vez vamos ver uma Exception que vem de uma biblioteca");

			Console.WriteLine("A gente cria uma lista");
			List<String> lista = new List<String>();

			Console.WriteLine("Coloca o primeiro item");
			lista.Add("Meu item");


			try
			{
				Console.WriteLine("E vamos TENTAR acessar o item na coordenada 1...");
				Console.WriteLine(lista[1]);
			}
			catch (Exception exception)
			{
				Console.WriteLine();
				Console.WriteLine("Mas o código vai dar esse erro:");
				Console.WriteLine(exception);

				Console.WriteLine();
				Console.WriteLine("Porque só existe o item 0:");
				Console.WriteLine(lista[0]);
			}
		}
	}
}
