using System;

namespace _2_HasControlledException
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Oi!");
			Console.WriteLine("Eu sou o terceiro programa");
			Console.WriteLine("Eu conheço a ideia de Exception");
			Console.WriteLine("Mas eu sei como impedir as Exceptions de causarem a minha parada!");

			try
			{
				Console.WriteLine("Aqui estou eu, executando feliz...");
				Console.WriteLine("Então, acontece a Exception:");

				throw new Exception();

				Console.WriteLine("Essa linha aqui foi impedida de executar!");
			}
			catch (Exception exception)
			{
				Console.WriteLine("Mas eu impeço a Exception de me parar!");
			}

			Console.WriteLine("Assim eu consigo terminar feliz como o primeiro programa!");
		}
	}
}
