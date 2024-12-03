using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectReserve.Models
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private string _sobrenome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public string Sobrenome
        {
            get => _sobrenome;
            set => _sobrenome = value;
        }
    }
}