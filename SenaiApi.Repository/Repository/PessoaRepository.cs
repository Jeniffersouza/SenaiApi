using Microsoft.EntityFrameworkCore;
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
            return GetAll().Include(c => c.Endereco).ToList();
        }
        public bool SalvarPessoa(Pessoa pessoa)
        {
            try
            {
                Salvar(pessoa);
                return true;

            }catch (Exception ex) {

                return false;
            }
        }

        public bool RemoverPessoa(long id)
        {
            try
            {
                Remover(id);
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
