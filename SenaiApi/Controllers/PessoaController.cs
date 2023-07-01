using Microsoft.AspNetCore.Mvc;
using SenaiApi.Domain.Dtos;
using SenaiApi.Service.Interface;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        
        private readonly IPessoaService _pessooaService;
        public PessoaController(IPessoaService pessoaService) 
        {
            _pessooaService = pessoaService;
        }
        
        [HttpPost]
        public IActionResult Salvar([FromBody]PessoaDto pessoa)
        {
            try
            {
                
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }          
        }

    }
}
