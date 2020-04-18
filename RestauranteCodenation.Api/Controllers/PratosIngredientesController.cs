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
    public class PratosIngredientesController : ControllerBase
    {
        private readonly IPratosIngredientesAplicacao _repo;
        public PratosIngredientesController(IPratosIngredientesAplicacao repo)
        {
            _repo = repo;
        }
        // GET: api/PratosIngredientes
        [HttpGet]
        public IEnumerable<PratosIngredientesViewModel> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/PratosIngredientes/5
        [HttpGet("{id}")]
        public PratosIngredientesViewModel Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST: api/PratosIngredientes
        [HttpPost]
        public PratosIngredientesViewModel Post([FromBody] PratosIngredientesViewModel pratosIngredientes)
        {
            _repo.Incluir(pratosIngredientes);
            return pratosIngredientes;
        }

        // PUT: api/PratosIngredientes/5
        [HttpPut("{id}")]
        public PratosIngredientesViewModel Put(int id, [FromBody] PratosIngredientesViewModel pratosIngredientes)
        {
            _repo.Alterar(pratosIngredientes);
            return pratosIngredientes;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<PratosIngredientesViewModel> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
