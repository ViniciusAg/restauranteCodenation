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
    public class TipoPratoController : ControllerBase
    {
        private readonly ITipoPratoAplicacao _repo;
        public TipoPratoController(ITipoPratoAplicacao repo)
        {
            _repo = repo;
        }
        // GET: api/TipoPrato
        [HttpGet]
        public IEnumerable<TipoPratoViewModel> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/TipoPrato/5
        [HttpGet("{id}")]
        public TipoPratoViewModel Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST: api/TipoPrato
        [HttpPost]
        public TipoPratoViewModel Post([FromBody] TipoPratoViewModel tipoPrato)
        {
            _repo.Incluir(tipoPrato);
            return tipoPrato;
        }

        // PUT: api/TipoPrato/5
        [HttpPut("{id}")]
        public TipoPratoViewModel Put(int id, [FromBody] TipoPratoViewModel tipoPrato)
        {
            _repo.Alterar(tipoPrato);
            return tipoPrato;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<TipoPratoViewModel> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
