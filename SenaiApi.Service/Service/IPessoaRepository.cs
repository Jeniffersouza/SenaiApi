using SenaiApi.Domain.Entidades;

namespace SenaiApi.Service.Service
{
    public interface IPessoaRepository
    {
        List<Pessoa> PegarTodasAsPessoas();
    }
}