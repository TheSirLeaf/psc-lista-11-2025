using System;

namespace Models
{
    public class Moto : Veiculo
    {
        public Moto(string marca, string modelo, int ano)
            : base(marca, modelo, ano)
        {
        }

        public override void acelerar()
        {
            Console.WriteLine($"{modelo} {marca} está acelerando e empinando a roda dianteira!");
        }
    }
}
