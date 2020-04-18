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
    public class AgendaCardapioController : ControllerBase
    {
        private readonly IAgendaCardapioAplicacao _repo;
        public AgendaCardapioController(IAgendaCardapioAplicacao repo)
        {
            _repo = repo;
        }
        // GET: api/AgendaCardapio
        [HttpGet]
        public IEnumerable<AgendaCardapioViewModel> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/AgendaCardapio/5
        [HttpGet("{id}")]
        public AgendaCardapioViewModel Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST: api/AgendaCardapio
        [HttpPost]
        public AgendaCardapioViewModel Post([FromBody] AgendaCardapioViewModel agendaCardapio)
        {
            _repo.Incluir(agendaCardapio);
            return agendaCardapio;
        }

        // PUT: api/AgendaCardapio/5
        [HttpPut("{id}")]
        public AgendaCardapioViewModel Put(int id, [FromBody] AgendaCardapioViewModel agendaCardapio)
        {
            _repo.Alterar(agendaCardapio);
            return agendaCardapio;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<AgendaCardapioViewModel> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
