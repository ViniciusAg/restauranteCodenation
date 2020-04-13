using RestauranteCodenation.Domain;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestauranteCodenation.Domain.Repositorio;

namespace RestauranteCodenation.Data.Repositorio
{
    public class PratosIngredientesRepositorio : RepositorioBase<PratosIngredientes>, IPratosIngredientesRepositorio
    {
        public List<PratosIngredientes> SelecionarCompleto()
        {
            return _contexto.PratosIngredientes
                            .Include(x => x.Ingrediente)
                            .Include(x => x.Prato)
                            .ToList();
        }
    }
}
