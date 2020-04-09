using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class Agenda : IEntity
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public List<AgendaCardapio> AgendaCardapio { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
    }
}
