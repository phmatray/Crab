using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using WsCrabServiceReference;
using CodeItem = Crab.NetCoreApi.Models.CodeItem;

namespace Crab.NetCoreApi
{
    public class AutoMapperProfileConfiguration : Profile
    {
        protected override void Configure()
        {
            CreateMap<GemeenteItem, CommuneItem>()
                .ForMember(dest => dest.CommuneId, conf => conf.MapFrom(src => src.GemeenteId))
                .ForMember(dest => dest.CommuneName, conf => conf.MapFrom(src => src.GemeenteNaam))
                .ForMember(dest => dest.CommuneNameLanguageCode, conf => conf.MapFrom(src => src.TaalCodeGemeenteNaam))
                .ForMember(dest => dest.LanguageCode, conf => conf.MapFrom(src => src.TaalCode))
                .ForMember(dest => dest.LanguageCode2, conf => conf.MapFrom(src => src.TaalCodeTweedeTaal))
                .ForMember(dest => dest.CommuneNISCode, conf => conf.MapFrom(src => src.NISGemeenteCode));

            CreateMap<HuisnummerItem, HousenumberItem>()
                .ForMember(dest => dest.HousenumberId, conf => conf.MapFrom(src => src.HuisnummerId))
                .ForMember(dest => dest.Housenumber, conf => conf.MapFrom(src => src.Huisnummer));

            CreateMap<HuisnummerWithStatusItem, HousenumberWithStatusItem>()
                .ForMember(dest => dest.HousenumberId, conf => conf.MapFrom(src => src.HuisnummerId))
                .ForMember(dest => dest.Housenumber, conf => conf.MapFrom(src => src.Huisnummer))
                .ForMember(dest => dest.StatusHousenumber, conf => conf.MapFrom(src => src.StatusHuisnummer));

            CreateMap<StraatnaamItem, StreetnameItem>()
                .ForMember(dest => dest.StreetnameId, conf => conf.MapFrom(src => src.StraatnaamId))
                .ForMember(dest => dest.Streetname, conf => conf.MapFrom(src => src.Straatnaam))
                .ForMember(dest => dest.Streetname2, conf => conf.MapFrom(src => src.StraatnaamTweedeTaal))
                .ForMember(dest => dest.LanguageCode, conf => conf.MapFrom(src => src.TaalCode))
                .ForMember(dest => dest.LanguageCode2, conf => conf.MapFrom(src => src.TaalCodeTweedeTaal))
                .ForMember(dest => dest.StreetnameLabel, conf => conf.MapFrom(src => src.StraatnaamLabel));

            CreateMap<StraatnaamWithStatusItem, StreetnameWithStatusItem>()
                .ForMember(dest => dest.StreetnameId, conf => conf.MapFrom(src => src.StraatnaamId))
                .ForMember(dest => dest.Streetname, conf => conf.MapFrom(src => src.Straatnaam))
                .ForMember(dest => dest.Streetname2, conf => conf.MapFrom(src => src.StraatnaamTweedeTaal))
                .ForMember(dest => dest.LanguageCode, conf => conf.MapFrom(src => src.TaalCode))
                .ForMember(dest => dest.LanguageCode2, conf => conf.MapFrom(src => src.TaalCodeTweedeTaal))
                .ForMember(dest => dest.StreetnameLabel, conf => conf.MapFrom(src => src.StraatnaamLabel))
                .ForMember(dest => dest.StatusStreetname, conf => conf.MapFrom(src => src.StatusStraatnaam));

            CreateMap<SubadresItem, SubaddressItem>()
                .ForMember(dest => dest.SubaddressId, conf => conf.MapFrom(src => src.SubadresId))
                .ForMember(dest => dest.Subaddress, conf => conf.MapFrom(src => src.Subadres));

            CreateMap<SubadresWithStatusItem, SubaddressWithStatusItem>()
                .ForMember(dest => dest.SubaddressId, conf => conf.MapFrom(src => src.SubadresId))
                .ForMember(dest => dest.Subaddress, conf => conf.MapFrom(src => src.Subadres))
                .ForMember(dest => dest.StatusSubaddress, conf => conf.MapFrom(src => src.StatusSubadres));
            
            CreateMap<AdrespositieObject, AddresspositionObject>()
                .ForMember(dest => dest.AddresspositionId, conf => conf.MapFrom(src => src.AdrespositieId))
                .ForMember(dest => dest.AddresspositionProvenance, conf => conf.MapFrom(src => src.HerkomstAdrespositie))
                .ForMember(dest => dest.Geometry, conf => conf.MapFrom(src => src.Geometrie))
                .ForMember(dest => dest.AddressType, conf => conf.MapFrom(src => src.AardAdres))
                .ForMember(dest => dest.AddressId, conf => conf.MapFrom(src => src.AdresId))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));
            
            CreateMap<GebouwObject, BuildingObject>()
                .ForMember(dest => dest.BuildingId, conf => conf.MapFrom(src => src.IdentificatorGebouw))
                .ForMember(dest => dest.BuildingType, conf => conf.MapFrom(src => src.AardGebouw))
                .ForMember(dest => dest.StatusBuilding, conf => conf.MapFrom(src => src.StatusGebouw))
                .ForMember(dest => dest.GeometrymethodBuilding, conf => conf.MapFrom(src => src.GeometriemethodeGebouw))
                .ForMember(dest => dest.Geometry, conf => conf.MapFrom(src => src.Geometrie))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<GemeenteObject, CommuneObject>()
                .ForMember(dest => dest.RegionId, conf => conf.MapFrom(src => src.GewestId))
                .ForMember(dest => dest.CommuneId, conf => conf.MapFrom(src => src.GemeenteId))
                .ForMember(dest => dest.CommuneName, conf => conf.MapFrom(src => src.GemeenteNaam))
                .ForMember(dest => dest.CommuneNameLanguageCode, conf => conf.MapFrom(src => src.TaalCodeGemeenteNaam))
                .ForMember(dest => dest.LanguageCode, conf => conf.MapFrom(src => src.TaalCode))
                .ForMember(dest => dest.LanguageCode2, conf => conf.MapFrom(src => src.TaalCodeTweedeTaal))
                .ForMember(dest => dest.CommuneNISCode, conf => conf.MapFrom(src => src.NisGemeenteCode))
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

            CreateMap<GewestObject, RegionObject>()
                .ForMember(dest => dest.RegionId, conf => conf.MapFrom(src => src.GewestId))
                .ForMember(dest => dest.RegionNameLanguageCode, conf => conf.MapFrom(src => src.TaalCodeGewestNaam))
                .ForMember(dest => dest.RegionName, conf => conf.MapFrom(src => src.GewestNaam))
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

            CreateMap<HuisnummerObject, HousenumberObject>()
                .ForMember(dest => dest.StreetnameId, conf => conf.MapFrom(src => src.StraatnaamId))
                .ForMember(dest => dest.HousenumberId, conf => conf.MapFrom(src => src.HuisnummerId))
                .ForMember(dest => dest.Housenumber, conf => conf.MapFrom(src => src.Huisnummer))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<HuisnummerWithStatusObject, HousenumberWithStatusObject>()
                .ForMember(dest => dest.StreetnameId, conf => conf.MapFrom(src => src.StraatnaamId))
                .ForMember(dest => dest.HousenumberId, conf => conf.MapFrom(src => src.HuisnummerId))
                .ForMember(dest => dest.Housenumber, conf => conf.MapFrom(src => src.Huisnummer))
                .ForMember(dest => dest.StatusHousenumber, conf => conf.MapFrom(src => src.StatusHuisnummer))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<PerceelObject, ParcelObject>()
                .ForMember(dest => dest.ParcelId, conf => conf.MapFrom(src => src.IdentificatorPerceel))
                .ForMember(dest => dest.CenterX, conf => conf.MapFrom(src => src.CenterX))
                .ForMember(dest => dest.CenterY, conf => conf.MapFrom(src => src.CenterY))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<PostadresObject, PostaladdressObject>()
                .ForMember(dest => dest.Postaladdress, conf => conf.MapFrom(src => src.Postadres));

            CreateMap<PostkantonObject, PostalcantonObject>()
                .ForMember(dest => dest.PostalcantonId, conf => conf.MapFrom(src => src.PostkantonId))
                .ForMember(dest => dest.PostalcantonCode, conf => conf.MapFrom(src => src.PostkantonCode))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<RijksregisterstraatObject, NationalregisterstreetObject>()
                .ForMember(dest => dest.StreetCode, conf => conf.MapFrom(src => src.StraatCode))
                .ForMember(dest => dest.SubcantonCode, conf => conf.MapFrom(src => src.SubkantonCode))
                .ForMember(dest => dest.Streetname, conf => conf.MapFrom(src => src.Straatnaam))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<StraatnaamObject, StreetnameObject>()
                .ForMember(dest => dest.CommuneId, conf => conf.MapFrom(src => src.GemeenteId))
                .ForMember(dest => dest.StreetnameId, conf => conf.MapFrom(src => src.StraatnaamId))
                .ForMember(dest => dest.Streetname, conf => conf.MapFrom(src => src.Straatnaam))
                .ForMember(dest => dest.Streetname2, conf => conf.MapFrom(src => src.StraatnaamTweedeTaal))
                .ForMember(dest => dest.LanguageCode, conf => conf.MapFrom(src => src.TaalCode))
                .ForMember(dest => dest.LanguageCode2, conf => conf.MapFrom(src => src.TaalCodeTweedeTaal))
                .ForMember(dest => dest.StreetnameLabel, conf => conf.MapFrom(src => src.StraatnaamLabel))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<StraatnaamWithStatusObject, StreetnameWithStatusObject>()
                .ForMember(dest => dest.CommuneId, conf => conf.MapFrom(src => src.GemeenteId))
                .ForMember(dest => dest.StreetnameId, conf => conf.MapFrom(src => src.StraatnaamId))
                .ForMember(dest => dest.Streetname, conf => conf.MapFrom(src => src.Straatnaam))
                .ForMember(dest => dest.Streetname2, conf => conf.MapFrom(src => src.StraatnaamTweedeTaal))
                .ForMember(dest => dest.LanguageCode, conf => conf.MapFrom(src => src.TaalCode))
                .ForMember(dest => dest.LanguageCode2, conf => conf.MapFrom(src => src.TaalCodeTweedeTaal))
                .ForMember(dest => dest.StreetnameLabel, conf => conf.MapFrom(src => src.StraatnaamLabel))
                .ForMember(dest => dest.StatusStreetname, conf => conf.MapFrom(src => src.StatusStraatnaam))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<SubadresObject, SubaddressObject>()
                .ForMember(dest => dest.HousenumberId, conf => conf.MapFrom(src => src.HuisnummerId))
                .ForMember(dest => dest.SubaddressId, conf => conf.MapFrom(src => src.SubadresId))
                .ForMember(dest => dest.Subaddress, conf => conf.MapFrom(src => src.Subadres))
                .ForMember(dest => dest.SubaddressType, conf => conf.MapFrom(src => src.AardSubadres))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<SubadresWithStatusObject, SubaddressWithStatusObject>()
                .ForMember(dest => dest.HousenumberId, conf => conf.MapFrom(src => src.HuisnummerId))
                .ForMember(dest => dest.SubaddressId, conf => conf.MapFrom(src => src.SubadresId))
                .ForMember(dest => dest.Subaddress, conf => conf.MapFrom(src => src.Subadres))
                .ForMember(dest => dest.SubaddressType, conf => conf.MapFrom(src => src.AardSubadres))
                .ForMember(dest => dest.StatusSubaddress, conf => conf.MapFrom(src => src.StatusSubadres))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<TerreinobjectObject, TerrainobjectObject>()
                .ForMember(dest => dest.TerrainobjectId, conf => conf.MapFrom(src => src.IdentificatorTerreinobject))
                .ForMember(dest => dest.TerrainobjectType, conf => conf.MapFrom(src => src.AardTerreinobject))
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

            CreateMap<WegobjectObject, RoadobjectObject>()
                .ForMember(dest => dest.RoadobjectId, conf => conf.MapFrom(src => src.IdentificatorWegobject))
                .ForMember(dest => dest.RoadobjectType, conf => conf.MapFrom(src => src.AardWegobject))
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

            CreateMap<WegsegmentObject, RoadsegmentObject>()
                .ForMember(dest => dest.RoadsegmentId, conf => conf.MapFrom(src => src.IdentificatorWegsegment))
                .ForMember(dest => dest.StatusRoadsegment, conf => conf.MapFrom(src => src.StatusWegsegment))
                .ForMember(dest => dest.GeometrymethodRoadsegment, conf => conf.MapFrom(src => src.GeometriemethodeWegsegment))
                .ForMember(dest => dest.Geometry, conf => conf.MapFrom(src => src.Geometrie))
                .ForMember(dest => dest.StartDate, conf => conf.MapFrom(src => src.BeginDatum))
                .ForMember(dest => dest.StartTime, conf => conf.MapFrom(src => src.BeginTijd))
                .ForMember(dest => dest.StartExploitation, conf => conf.MapFrom(src => src.BeginBewerking))
                .ForMember(dest => dest.StartOrganisation, conf => conf.MapFrom(src => src.BeginOrganisatie));

            CreateMap<WsCrabServiceReference.CodeItem, CodeItem>()
                .ForMember(dest => dest.Code, conf => conf.MapFrom(src => src.Code))
                .ForMember(dest => dest.Name, conf => conf.MapFrom(src => src.Naam))
                .ForMember(dest => dest.Definition, conf => conf.MapFrom(src => src.Definitie));

            CreateMap<AdrespositieItem, AddresspositionItem>()
                .ForMember(dest => dest.AddresspositionId, conf => conf.MapFrom(src => src.AdrespositieId))
                .ForMember(dest => dest.AddresspositionProvenance, conf => conf.MapFrom(src => src.HerkomstAdrespositie));

            CreateMap<GebouwItem, BuildingItem>()
                .ForMember(dest => dest.BuildingId, conf => conf.MapFrom(src => src.IdentificatorGebouw))
                .ForMember(dest => dest.BuildingType, conf => conf.MapFrom(src => src.AardGebouw))
                .ForMember(dest => dest.StatusBuilding, conf => conf.MapFrom(src => src.StatusGebouw));

            CreateMap<GewestItem, RegionItem>()
                .ForMember(dest => dest.RegionId, conf => conf.MapFrom(src => src.GewestId))
                .ForMember(dest => dest.RegionNameLanguageCode, conf => conf.MapFrom(src => src.TaalCodeGewestNaam))
                .ForMember(dest => dest.RegionName, conf => conf.MapFrom(src => src.GewestNaam));

            CreateMap<PerceelItem, ParcelItem>()
                .ForMember(dest => dest.ParcelId, conf => conf.MapFrom(src => src.IdentificatorPerceel));

            CreateMap<PostadresItem, PostaladdressItem>()
                .ForMember(dest => dest.Postaladdress, conf => conf.MapFrom(src => src.Postadres));

            CreateMap<PostkantonItem, PostalcantonItem>()
                .ForMember(dest => dest.PostalcantonCode, conf => conf.MapFrom(src => src.PostkantonCode));

            CreateMap<RijksregisterstraatItem, NationalregisterstreetItem>()
                .ForMember(dest => dest.StreetCode, conf => conf.MapFrom(src => src.StraatCode))
                .ForMember(dest => dest.SubcantonCode, conf => conf.MapFrom(src => src.SubkantonCode));

            CreateMap<RijksregisterAdresItem, NationalregisterAddressItem>()
                .ForMember(dest => dest.NationalregisterAddressId, conf => conf.MapFrom(src => src.RijksregisterAdresId))
                .ForMember(dest => dest.Housenumber, conf => conf.MapFrom(src => src.Huisnummer))
                .ForMember(dest => dest.Index, conf => conf.MapFrom(src => src.Index))
                .ForMember(dest => dest.StreetCode, conf => conf.MapFrom(src => src.StraatCode))
                .ForMember(dest => dest.SubcantonCode, conf => conf.MapFrom(src => src.SubkantonCode));

            CreateMap<TerreinobjectItem, TerrainobjectItem>()
                .ForMember(dest => dest.TerrainobjectId, conf => conf.MapFrom(src => src.IdentificatorTerreinobject))
                .ForMember(dest => dest.TerrainobjectType, conf => conf.MapFrom(src => src.AardTerreinobject));

            CreateMap<WegobjectItem, RoadobjectItem>()
                .ForMember(dest => dest.RoadobjectId, conf => conf.MapFrom(src => src.IdentificatorWegobject))
                .ForMember(dest => dest.RoadobjectType, conf => conf.MapFrom(src => src.AardWegobject));

            CreateMap<WegsegmentItem, RoadsegmentItem>()
                .ForMember(dest => dest.RoadsegmentId, conf => conf.MapFrom(src => src.IdentificatorWegsegment))
                .ForMember(dest => dest.StatusRoadsegment, conf => conf.MapFrom(src => src.StatusWegsegment));









            //CreateMap<Application, ApplicationViewModel>();
            //CreateMap<ApplicationViewModel, Application>();
        }
    }
}
