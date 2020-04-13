using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class AgendaCardapioViewModel
    {
        public int Id { get; set; }
        public int IdCardapio { get; set; }
        public CardapioViewModel Cardapio { get; set; }
        public int IdAgenda { get; set; }
        public AgendaViewModel Agenda { get; set;  }
    }
}
