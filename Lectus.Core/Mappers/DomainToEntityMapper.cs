using System;
using AutoMapper;
using Lectus.Domain.Models;
using Lectus.Entity.Models;

namespace Lectus.Core.Mappers
{
    public static class DomainToEntityMapper
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new DomainToEntityProfile());
                cfg.AddProfile(new DomainToEntityProfile());
            });
        }
    }

    public class DomainToEntityProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ICountry, MstCountry>();
        }
    }

    public class EntityToDomainProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<MstCountry, ICountry>();
        }
    }
}
