using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface IAgendaCardapioAplicacao
    {
        void Incluir(AgendaCardapioViewModel entity);
        void Alterar(AgendaCardapioViewModel entity);
        AgendaCardapioViewModel SelecionarPorId(int id);
        void Excluir(int id);
        List<AgendaCardapioViewModel> SelecionarTodos();
    }
}
