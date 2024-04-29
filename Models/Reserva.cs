namespace Models
{
    class Reserva
    {
        List<Pessoa> Hospedes { get; set; }
        Suite Suite { get; set; }
        int DiasReservados { get; set; }

        public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
        {
            Hospedes = hospedes;
            Suite = suite;
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= 0)
            {
                throw new Exception("Nenhum hóspede encontrado.");
            }

            this.Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public int ObterQuantidadeDeHospedes()
        {
            return this.Hospedes.Count;
        }

        public decimal CalcularValorDaDiaria()
        {
            decimal valor = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                decimal desconto = (valor / 100) * 10;
                return valor -= desconto;
            }

            return valor;
        }
    }
}
