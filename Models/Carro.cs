using System;

namespace Models
{
    public class Carro : Veiculo
    {
        public double tempoZeroACem;

        public Carro(string marca, string modelo, int ano, double tempoZeroACem)
            : base(marca, modelo, ano)
        {
            this.tempoZeroACem = tempoZeroACem;
        }

        public override void acelerar()
        {
            Console.WriteLine($"{modelo} {marca} está acelerando de 0 a 100 km/h em {tempoZeroACem} segundos.");
        }
    }
}
