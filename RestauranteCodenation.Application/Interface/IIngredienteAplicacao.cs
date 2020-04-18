﻿using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface IIngredienteAplicacao
    {
        void Incluir(IngredienteViewModel entity);
        void Alterar(IngredienteViewModel entity);
        IngredienteViewModel SelecionarPorId(int id);
        void Excluir(int id);
        List<IngredienteViewModel> SelecionarTodos();
    }
}
