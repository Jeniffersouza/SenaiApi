using SenaiApi.Domain.Entidades;
using SenaiApi.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Domain.Dtos
{
    public class PessoaDto
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public EnderecoDto Endereco { get; set; }
    }
}
