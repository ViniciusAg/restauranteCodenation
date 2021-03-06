﻿using AutoMapper;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;
using RestauranteCodenation.Domain;
using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.App
{
    public class PratoAplicacao : IPratoAplicacao
    {
        private readonly IPratoRepositorio _repo;
        private readonly IMapper _mapper;
        public PratoAplicacao(IPratoRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public void Alterar(PratoViewModel entity)
        {
            _repo.Alterar(_mapper.Map<Prato>(entity));
        }

        public void Excluir(int id)
        {
            _repo.Excluir(id);
        }

        public void Incluir(PratoViewModel entity)
        {
            _repo.Incluir(_mapper.Map<Prato>(entity));
        }

        public PratoViewModel SelecionarPorId(int id)
        {
            return _mapper.Map<PratoViewModel>(_repo.SelecionarPorId(id));
        }

        public List<PratoViewModel> SelecionarTodos()
        {
            return _mapper.Map<List<PratoViewModel>>(_repo.SelecionarTodos());
        }
    }
}
