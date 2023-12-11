using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dados.EntityFramework;
using Dominio.Entities;
using Servico.Interface;
using Servico.Services;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RacaController : Controller
    {
        private readonly IRacaService _racaService;

        public RacaController(IRacaService racaService)
        {
            _racaService = racaService;
        }

        [HttpGet]
        public List<Raca> Listar()
        {
            return _racaService.Listar();
        }

        [HttpGet]
        [Route("BuscarPorId")]
        public Raca Buscar(int id)
        {
            return _racaService.BuscarPorId(id);
        }

        [HttpPost]
        [Route("Adicionar")]
        public ActionResult<bool> Adicionar(Raca ent)
        {
            var result = _racaService.Adicionar(ent);
            return Ok(result);
        }


    }

   
}
