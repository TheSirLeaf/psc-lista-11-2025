using System;

namespace Models
{
    public abstract class Veiculo
    {
        public string marca;
        public string modelo;
        public int ano;

        public Veiculo(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        public void exibirDetalhes()
        {
            Console.WriteLine($"Marca: {marca} | Modelo: {modelo} | Ano: {ano}");
        }

        public abstract void acelerar();
    }
}
