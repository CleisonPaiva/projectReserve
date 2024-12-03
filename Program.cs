using projectReserve.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Cleison", "Paiva");
Pessoa p2 = new Pessoa("João", "Silva");
Pessoa p3 = new Pessoa("Maria", "Santos");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 50.00M);
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");