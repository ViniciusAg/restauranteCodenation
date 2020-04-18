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
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaAplicacao _repo;
        public AgendaController(IAgendaAplicacao repo)
        {
            _repo = repo;
        }
        // GET: api/Agenda
        [HttpGet]
        public IEnumerable<AgendaViewModel> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/Agenda/5
        [HttpGet("{id}")]
        public AgendaViewModel Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST: api/Agenda
        [HttpPost]
        public AgendaViewModel Post([FromBody] AgendaViewModel agenda)
        {
            _repo.Incluir(agenda);
            return agenda;
        }

        // PUT: api/Agenda/5
        [HttpPut("{id}")]
        public AgendaViewModel Put(int id, [FromBody] AgendaViewModel agenda)
        {
            _repo.Alterar(agenda);
            return agenda;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<AgendaViewModel> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
