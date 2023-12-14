using Dominio;
using Dominio.Entities;
using Microsoft.AspNetCore.Mvc;
using Servico.Interface;
using Servico.Services;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ImagemController : Controller
    {
        private readonly IImagemService _imageService;
        public ImagemController( IImagemService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost]
        public ActionResult<Task<Imagem>> Adicionar(Imagem ent)
        {
         
            var result = _imageService.Adicionar(ent);
            if (result == false)
            {
                return BadRequest("Não foi possível cadastrar cachorro!");
            }
            return Ok(ent);

        }
    }
}
