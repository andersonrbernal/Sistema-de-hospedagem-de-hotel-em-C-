using Models;

namespace Models
{
    class Suite
    {
        public string TipoDeSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipoDeSuite, int capacidade, decimal valorDiaria)
        {
            TipoDeSuite = tipoDeSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}
