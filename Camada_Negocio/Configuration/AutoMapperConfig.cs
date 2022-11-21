using Camada_Negocio.Model;
using AutoMapper;
using Camada_Dados.Repository.Entity;

namespace Web_Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Aluno, AlunoModel>().ReverseMap();
            CreateMap<Escola, EscolaModel>().ReverseMap();
            CreateMap<Professor, ProfessorModel>().ReverseMap();
        }
    }
}
