using System;

namespace _1_HasException
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Oi!");
			Console.WriteLine("Eu sou um programa diferente");
			Console.WriteLine("A linha abaixo vai me fazer parar de executar");

			throw new Exception();

			Console.WriteLine("E essa linha aqui nem vai ser impressa na tela");
		}
	}
}
