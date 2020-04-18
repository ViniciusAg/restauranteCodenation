using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface IAgendaAplicacao
    {
        void Incluir(AgendaViewModel entity);
        void Alterar(AgendaViewModel entity);
        AgendaViewModel SelecionarPorId(int id);
        void Excluir(int id);
        List<AgendaViewModel> SelecionarTodos();
    }
}
