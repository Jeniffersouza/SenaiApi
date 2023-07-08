using SenaiApi.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Repository.Interface
{
    public interface IPessoaRepository
    {
        List<Pessoa> PegarTodasAsPessoas();
        bool SalvarPessoa(Pessoa pessoa);
        bool RemoverPessoa(long id);
    }
}
