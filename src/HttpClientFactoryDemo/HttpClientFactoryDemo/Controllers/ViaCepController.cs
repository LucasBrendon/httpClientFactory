using HttpClientFactoryDemo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViaCepController : ControllerBase
    {
        private readonly IViaCepHttpService _viaCepHttpService;

        public ViaCepController(IViaCepHttpService viaCepHttpService)
        {
            _viaCepHttpService = viaCepHttpService;
        }

        [HttpGet("get-endereco/{cep}")]
        public async Task<IActionResult> RealizarBuscaViaCep(int cep)
        {
            var result = await _viaCepHttpService.ConsultarEndereco(cep);

            return Ok(result);
        }

    }
}
