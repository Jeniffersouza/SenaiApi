using SenaiApi.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Service.Interface
{
    public interface IPessoaService
    {
        void Salvar(PessoaDto pessoa);
    }
}
