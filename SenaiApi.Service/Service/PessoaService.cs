using SenaiApi.Domain.Dtos;
using SenaiApi.Domain.Entidades;
using SenaiApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Service.Service
{
    public class PessoaService : IPessoaService
    {
        private IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository) {
            _pessoaRepository = pessoaRepository;
        }  

        public List<Pessoa> BuscarTodos()
        {
            return _pessoaRepository.PegarTodasAsPessoas();
        }
        
        public void Salvar(PessoaDto pessoa)
        {
            throw new NotImplementedException();
        }

        
    }
}
