using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Data.Request;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastraUsuario([FromBody] CreateUsuarioDto usuarioDto)
        {
            Result resultado = _cadastroService.CadastraUsuario(usuarioDto);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok(resultado.Successes.FirstOrDefault());
        }

        [HttpGet("/ativa")]
        public IActionResult AtivaContaUsuario([FromQuery] AtivaContaRequest request)
        {
            Result resultado = _cadastroService.AtivaContaUsuario(request);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok(resultado.Successes.FirstOrDefault());
        }

    }
}
