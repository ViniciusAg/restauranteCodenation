﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class TipoPratoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<PratoViewModel> Pratos { get; set; }
    }
}
