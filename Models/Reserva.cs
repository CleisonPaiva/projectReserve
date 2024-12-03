using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectReserve.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }
        private int _diasReservados;
        List<Pessoa> Hospedes { get; set; }
        Suite Suite { get; set; }
        int DiasReservados
        {
            get => _diasReservados;
            set => _diasReservados = value;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("O número de hóspedes é maior que a capacidade da suite.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            return DiasReservados * Suite.ValorDiaria;
        }
    }
}