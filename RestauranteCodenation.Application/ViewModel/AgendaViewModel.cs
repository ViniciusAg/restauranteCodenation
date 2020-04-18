using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.ViewModel
{
    public class AgendaViewModel
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public List<AgendaCardapioViewModel> AgendaCardapio { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
    }
}
