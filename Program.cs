using Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Pessoa> hospedes = [];

Pessoa pessoa = new("Edleuza", "Aparecida");
Pessoa pessoa2 = new("Afonso", "Moreno");

hospedes.Add(pessoa);
hospedes.Add(pessoa2);

Suite suite = new("Premium", 2, 100);

Reserva reserva = new(hospedes, suite, 10);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDaDiaria()}");
