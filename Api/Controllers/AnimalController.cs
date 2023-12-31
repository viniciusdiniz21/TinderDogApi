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
        private readonly IImagemService _imageService;

        public AnimalController(ICurtidaService curtidaService, IAnimalService animalService, IImagemService imageService)
        {
            _curtidaService = curtidaService;
            _animalService = animalService;
            _imageService = imageService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Animal>>> Buscar()
        {
            var objeto = await _animalService.Listar();

            return Ok(objeto);
        }

        [HttpPost]
        public ActionResult<Task<Animal>> Adicionar(Animal ent)
        {
            var animal = _animalService.BuscarPorUsuarioId(ent.UsuarioId);
            if(animal == null)
            {
                var result = _animalService.Adicionar(ent);

                if(result == false)
                {
                    return BadRequest("Não foi possível cadastrar cachorro!");
                }
                return Ok(ent); 
            }
            return BadRequest("Já possui cachorro cadastrado!");
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
            var imagens = objeto.Imagems;
            foreach( var imagem in imagens )
            {
                _imageService.Adicionar(imagem);
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
