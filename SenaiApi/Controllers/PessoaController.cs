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

        [HttpGet]
        public IActionResult Get()
        {
            var pessoas = _pessooaService.BuscarTodos();
            return new JsonResult(pessoas);
        }


        [HttpPost]
        public IActionResult Salvar([FromBody]PessoaDto pessoa)
        {
            try
            {
                _pessooaService.Salvar(pessoa);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }          
        }

    }
}
