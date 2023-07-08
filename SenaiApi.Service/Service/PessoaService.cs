using AutoMapper;
using SenaiApi.Domain.Dtos;
using SenaiApi.Domain.Entidades;
using SenaiApi.Repository.Interface;
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
        private IMapper _mapper;
        private IPessoaRepository _pessoaRepository;
        public PessoaService(IMapper mapper, IPessoaRepository pessoaRepository) {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }  

        public List<Pessoa> BuscarTodos()
        {
            return _pessoaRepository.PegarTodasAsPessoas();
        }

        public bool RemoverPessoa(long id)
        {
            return _pessoaRepository.RemoverPessoa(id);
        }

        public bool Salvar(PessoaDto pessoaDto)
        {
            var pessoa = _mapper.Map<Pessoa>(pessoaDto);
            return _pessoaRepository.SalvarPessoa(pessoa);
        }

        
    }
}
