using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;
using RestauranteCodenation.Data.Repositorio;
using RestauranteCodenation.Domain;
using RestauranteCodenation.Domain.Repositorio;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardapioController : ControllerBase
    {
        private readonly ICardapioAplicacao _repo;
        public CardapioController(ICardapioAplicacao repo)
        {
            _repo = repo;
        }
        // GET: api/Cardapio
        [HttpGet]
        public IEnumerable<CardapioViewModel> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/Cardapio/5
        [HttpGet("{id}")]
        public CardapioViewModel Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST: api/Cardapio
        [HttpPost]
        public CardapioViewModel Post([FromBody] CardapioViewModel cardapio)
        {
            _repo.Incluir(cardapio);
            return cardapio;
        }

        // PUT: api/Cardapio/5
        [HttpPut("{id}")]
        public CardapioViewModel Put(int id, [FromBody] CardapioViewModel cardapio)
        {
            _repo.Alterar(cardapio);
            return cardapio;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<CardapioViewModel> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
