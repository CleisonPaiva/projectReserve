using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectReserve.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string? tipoSuite, int capacidade, decimal valorDiaria)
        {
            this.TipoSuite = tipoSuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = valorDiaria;
        }
        private string _tipoSuite;
        private int _capacidade;
        private decimal _ValorDiaria;

        public string? TipoSuite
        {
            get => _tipoSuite;
            set => _tipoSuite = value;
        }
        public int Capacidade
        {
            get => _capacidade;
            set => _capacidade = value;
        }
        public decimal ValorDiaria
        {
            get => _ValorDiaria;
            set => _ValorDiaria = value;
        }


    }
}