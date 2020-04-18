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
    public class PratoController : ControllerBase
    {
        private readonly IPratoAplicacao _repo;
        public PratoController(IPratoAplicacao repo)
        {
            _repo = repo;
        }
        // GET: api/Prato
        [HttpGet]
        public IEnumerable<PratoViewModel> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/Prato/5
        [HttpGet("{id}")]
        public PratoViewModel Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST: api/Prato
        [HttpPost]
        public PratoViewModel Post([FromBody] PratoViewModel prato)
        {
            _repo.Incluir(prato);
            return prato;
        }

        // PUT: api/Prato/5
        [HttpPut("{id}")]
        public PratoViewModel Put(int id, [FromBody] PratoViewModel prato)
        {
            _repo.Alterar(prato);
            return prato;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<PratoViewModel> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
