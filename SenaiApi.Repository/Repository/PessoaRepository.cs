using SenaiApi.Domain.Entidades;
using SenaiApi.Repository.Context;
using SenaiApi.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Repository.Repository
{
    public class PessoaRepository : GenericRepository<Pessoa>,   IPessoaRepository 
    {
        

        public PessoaRepository(ApiContext context) : base(context) { }
        public List<Pessoa> PegarTodasAsPessoas()
        {
            return GetAll().ToList();
        }
    }
}
