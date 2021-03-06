﻿using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class Prato : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<PratosIngredientes> PratosIngredientes { get; set; }
        public decimal Preco { get; set; }
        public int IdTipoPrato { get; set; }
        public TipoPrato TipoPrato { get; set; }


    }
}
