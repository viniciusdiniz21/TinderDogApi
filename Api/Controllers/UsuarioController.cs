using Microsoft.AspNetCore.Mvc;
using Dados.EntityFramework;
using Dominio.Entities;
using Servico.Interface;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
            private readonly IUsuarioService _usuarioService;
            public UsuarioController(IUsuarioService usuarioService)
            {
                _usuarioService = usuarioService;
            }

            //public IActionResult Index()
            //{
            //    var resultado = _usuarioService.Listar();
            //    return View(resultado);
            //}
            //[Route("Inserir")]

            //public IActionResult Inserir()
            //{
            //    var ent = new Usuario();
            //    return View(ent);
            //}

            //[HttpPost]
            //public IActionResult InserirConfirmar(Usuario ent)
            //{
            //    _usuarioService.Adicionar(ent);
            //    return RedirectToAction("Index");
            //}

            [HttpPost]
            [Route("Cadastrar")]
            public ActionResult<Usuario> Adicionar(Usuario ent)
            {
                _usuarioService.Adicionar(ent);
                return Ok(ent);
            }


    }
}
