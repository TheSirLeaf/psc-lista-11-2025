using System;

namespace Models
{
    public class Caminhao : Veiculo
    {
        public Caminhao(string marca, string modelo, int ano)
            : base(marca, modelo, ano)
        {
        }

        public override void acelerar()
        {
            Console.WriteLine($"{modelo} {marca} está engrenando a próxima marcha e acelerando lentamente.");
        }
    }
}
