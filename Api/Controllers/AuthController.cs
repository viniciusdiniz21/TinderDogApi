using Microsoft.AspNetCore.Mvc;
using Dados.Interface;
using Dominio.Entities;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepositorio _authRepositorio;
        public AuthController(IAuthRepositorio authRepositorio)
        {
            _authRepositorio = authRepositorio;
        }

        public class LoginDTO
        {
            public string Usuario { get; set; }
            public string Senha { get; set; }
        }


        [HttpPost]
        [Route("Cadastrar")]
        public async Task<ActionResult<Usuario>> Cadastrar([FromBody] LoginDTO usuario)
        {
            var user = new Usuario();
            user.Nome = usuario.Usuario;
            user.Senha = usuario.Senha;
            user.Animal = null;
            user.Token = null;
            user.Matchs = null;
            user.Ativo = true;
            if (!ModelState.IsValid)
                return BadRequest("Dados inválidos");
            //usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            var result = await _authRepositorio.Cadastrar(user);
            return Ok(result);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<dynamic>> Login([FromBody] LoginDTO usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dados inválidos");

            var user = _authRepositorio.BuscarUsuario(usuario.Usuario);
            if (user == null)
            {
                return BadRequest("Usuário não encontrado");
            }

            //if (!BCrypt.Net.BCrypt.Verify(user.Senha, usuario.Senha))
            //{
            //    return BadRequest("Credenciais Inválidas");
            //}
            if (user.Senha != usuario.Senha) return BadRequest("Credenciais Inválidas");
            string token = TokenService.GenerateToken(user);

            user.Token = token;

            return Ok(user);
        }

    }
}
