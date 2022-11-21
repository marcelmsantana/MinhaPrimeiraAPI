using Camada_Negocio.Model;
using AutoMapper;
using Camada_Dados.Repository.Entity;
using Camada_Negocio.Configuration;

namespace Web_Api.Configuration
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
        }
    }
}
