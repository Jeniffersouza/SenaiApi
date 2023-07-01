using SenaiApi.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Domain.Entidades
{
    public class Pessoa: BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime DataInserção { get; set; }
        public SexoEnum Sexo { get; set; }
        public Endereco Endereco { get; set; }

    }
}
