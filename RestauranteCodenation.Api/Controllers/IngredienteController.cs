﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Data.Repositorio;
using RestauranteCodenation.Domain;
using RestauranteCodenation.Domain.Repositorio;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        // repositorio mesmo nome da controller: _repo
        private readonly IIngredienteRepositorio _repo;
        public IngredienteController(IIngredienteRepositorio repo)
        {
            _repo = repo;

        }
        // GET: api/Ingrediente
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            return _repo.SelecionarTodos() ;
        }

        // GET: api/Ingrediente/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST: api/Ingrediente
        [HttpPost]
        public Ingrediente Post([FromBody] Ingrediente ingrediente)
        {
            _repo.Incluir(ingrediente);
            return ingrediente;
        }

        // PUT: api/Ingrediente/5
        [HttpPut]
        public Ingrediente Put([FromBody] Ingrediente ingrediente)
        {
            _repo.Alterar(ingrediente);
            return ingrediente;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<Ingrediente> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
