using AutoMapper;
using RestauranteCodenation.Application.App;
using RestauranteCodenation.Application.ViewModel;
using RestauranteCodenation.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(x => x.AllowNullCollections = true);
        }

        public AutoMapperConfig()
        {
            CreateMap<AgendaCardapio, AgendaCardapioViewModel>().ReverseMap();
            CreateMap<Agenda, AgendaViewModel>().ReverseMap();
            CreateMap<CardapioAplicacao, CardapioViewModel>().ReverseMap();
            CreateMap<IngredienteAplicacao, IngredienteViewModel>().ReverseMap();
            CreateMap<PratosIngredientesAplicacao, PratosIngredientesViewModel>().ReverseMap();
            CreateMap<PratoAplicacao, PratoViewModel>().ReverseMap();
            CreateMap<TipoPratoAplicacao, TipoPratoViewModel>().ReverseMap();
        }
    } 
}

