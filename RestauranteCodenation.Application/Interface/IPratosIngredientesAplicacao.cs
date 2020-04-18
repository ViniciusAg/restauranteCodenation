﻿using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface IPratosIngredientesAplicacao
    {
        List<PratosIngredientesViewModel> SelecionarCompleto();
        void Incluir(PratosIngredientesViewModel entity);
        void Alterar(PratosIngredientesViewModel entity);
        PratosIngredientesViewModel SelecionarPorId(int id);
        void Excluir(int id);
        List<PratosIngredientesViewModel> SelecionarTodos();
    }
}
