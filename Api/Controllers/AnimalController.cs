﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dados.EntityFramework;
using Dominio;
using Dominio.Entities;
using Servico.Interface;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalController : Controller
    {
        private readonly ICurtidaService _curtidaService;
        private readonly IAnimalService _animalService;

        public AnimalController(ICurtidaService curtidaService, IAnimalService animalService)
        {
            _curtidaService = curtidaService;
            _animalService = animalService;
        }

        [HttpGet]
        public ActionResult<List<Animal>> Buscar()
        {
            var objeto = _animalService.Listar();

            return Ok(objeto);
        }

        [HttpPost]
        public ActionResult<Animal> Adicionar(Animal ent)
        {
            var result = _animalService.Adicionar(ent);

            return Ok(ent);
        }
        
        [HttpPut]
        public ActionResult<Animal> Editar(Animal ent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var objeto = _animalService.BuscarPorId(ent.Id);
            if(objeto == null)
            {
                return BadRequest();
            }
            _animalService.Editar(objeto);


            return Ok(ent);
        }
        
        [HttpPost]
        [Route("Curtida")]
        public ActionResult<bool> Interagir(Curtida curtida)
        {

            if (!ModelState.IsValid)
                return BadRequest(BadRequest());

            var result = _curtidaService.Interacao(curtida);

            if(result == true)
            {
                return Created("Criado",result);
            }
            return Ok(result);
        }

        [HttpDelete]
        public bool Excluir(int id)
        {
            var result = _animalService.BuscarPorId(id);

            result.Ativo = false;

            _animalService.Editar(result);

            return true;
        }

    }


}
