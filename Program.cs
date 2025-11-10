using System;
using Models;

class SistemaVeiculos
{
	static void Main(string[] args)
	{
		Veiculo carro = new Carro("Ford", "Mustang", 2021, 4.2);
		Veiculo moto = new Moto("Honda", "CBR600RR", 2020);
		Veiculo caminhao = new Caminhao("Volvo", "FH", 2018);

		carro.exibirDetalhes();
		carro.acelerar();

		Console.WriteLine();

		moto.exibirDetalhes();
		moto.acelerar();

		Console.WriteLine();

		caminhao.exibirDetalhes();
		caminhao.acelerar();
	}
}
