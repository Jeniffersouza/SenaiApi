using SenaiApi.Domain.Dtos;
using SenaiApi.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Service.Interface
{
    public interface IPessoaService
    {
        List<Pessoa> BuscarTodos();

        bool   Salvar(PessoaDto pessoa);
        bool RemoverPessoa(long id);    
    }
}
