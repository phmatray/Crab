using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using WsCrabServiceReference;

namespace Crab.NetCoreApi
{
    public class AutoMapperProfileConfiguration : Profile
    {
        protected override void Configure()
        {
            CreateMap<GewestItem, RegionItem>()
                .ForMember(dest => dest.Id, conf => conf.MapFrom(src => src.GewestId))
                .ForMember(dest => dest.Name, conf => conf.MapFrom(src => src.GewestNaam))
                .ForMember(dest => dest.NameLanguageCode, conf => conf.MapFrom(src => src.TaalCodeGewestNaam));

            CreateMap<GewestObject, RegionObject>()
                .ForMember(dest => dest.Id, conf => conf.MapFrom(src => src.GewestId))
                .ForMember(dest => dest.NameLanguageCode, conf => conf.MapFrom(src => src.TaalCodeGewestNaam))
                .ForMember(dest => dest.Name, conf => conf.MapFrom(src => src.GewestNaam))
                .ForMember(dest => dest.CenterX, conf => conf.MapFrom(src => src.CenterX))
                .ForMember(dest => dest.CenterY, conf => conf.MapFrom(src => src.CenterY))
                .ForMember(dest => dest.MinimumX, conf => conf.MapFrom(src => src.MinimumX))
                .ForMember(dest => dest.MinimumY, conf => conf.MapFrom(src => src.MinimumY))
                .ForMember(dest => dest.MaximumX, conf => conf.MapFrom(src => src.MaximumX))
                .ForMember(dest => dest.MaximumY, conf => conf.MapFrom(src => src.MaximumY))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));


            //CreateMap<Application, ApplicationViewModel>();
            //CreateMap<ApplicationViewModel, Application>();
        }
    }
}
