using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Camada_Dados.Repository.Entity;
using Camada_Negocio.Model;

namespace Camada_Negocio.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Aluno, AlunoModel>().ReverseMap();
            CreateMap<Escola, EscolaModel>().ReverseMap();
            CreateMap<Professor, ProfessorModel>().ReverseMap();
        }
    }
}
