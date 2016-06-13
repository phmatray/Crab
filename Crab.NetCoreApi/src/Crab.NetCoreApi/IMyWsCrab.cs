using System.ServiceModel;
using System.Threading.Tasks;
using WsCrabServiceReference;

namespace Crab.NetCoreApi
{
    internal interface IMyWsCrab
    {
        Task<FindGemeentenResponse> FindGemeentenAsync(FindGemeentenRequest request);
        Task<FindHuisnummersResponse> FindHuisnummersAsync(FindHuisnummersRequest request);
        Task<FindHuisnummersWithStatusResponse> FindHuisnummersWithStatusAsync(FindHuisnummersWithStatusRequest request);
        //Task<FindStraatnamenResponse> FindStraatnamenAsync(FindStraatnamenRequest request);
        //Task<FindStraatnamenWithStatusResponse> FindStraatnamenWithStatusAsync(FindStraatnamenWithStatusRequest request);
        Task<FindSubadressenResponse> FindSubadressenAsync(FindSubadressenRequest request);
        Task<FindSubadressenWithStatusResponse> FindSubadressenWithStatusAsync(FindSubadressenWithStatusRequest request);
        Task<GetGebouwByIdentificatorGebouwResponse> GetGebouwByIdentificatorGebouwAsync(GetGebouwByIdentificatorGebouwRequest request);
        Task<GetGemeenteByGemeenteNaamResponse> GetGemeenteByGemeenteNaamAsync(GetGemeenteByGemeenteNaamRequest request);
        //Task<GetGewestByGewestIdAndTaalCodeResponse> GetGewestByGewestIdAndTaalCodeAsync(GetGewestByGewestIdAndTaalCodeRequest request);
        Task<GetHuisnummerByHuisnummerResponse> GetHuisnummerByHuisnummerAsync(GetHuisnummerByHuisnummerRequest request);
        Task<GetHuisnummerWithStatusByHuisnummerResponse> GetHuisnummerWithStatusByHuisnummerAsync(GetHuisnummerWithStatusByHuisnummerRequest request);
        Task<GetPerceelByIdentificatorPerceelResponse> GetPerceelByIdentificatorPerceelAsync(GetPerceelByIdentificatorPerceelRequest request);
        Task<GetStraatnaamByStraatnaamResponse> GetStraatnaamByStraatnaamAsync(GetStraatnaamByStraatnaamRequest request);
        Task<GetStraatnaamWithStatusByStraatnaamResponse> GetStraatnaamWithStatusByStraatnaamAsync(GetStraatnaamWithStatusByStraatnaamRequest request);
        Task<GetTerreinobjectByIdentificatorTerreinobjectResponse> GetTerreinobjectByIdentificatorTerreinobjectAsync(GetTerreinobjectByIdentificatorTerreinobjectRequest request);
        Task<GetWegobjectByIdentificatorWegobjectResponse> GetWegobjectByIdentificatorWegobjectAsync(GetWegobjectByIdentificatorWegobjectRequest request);
        Task<GetWegsegmentByIdentificatorWegsegmentResponse> GetWegsegmentByIdentificatorWegsegmentAsync(GetWegsegmentByIdentificatorWegsegmentRequest request);
        Task<ListAdrespositiesByHuisnummerResponse> ListAdrespositiesByHuisnummerAsync(ListAdrespositiesByHuisnummerRequest request);
        Task<ListAdrespositiesBySubadresResponse> ListAdrespositiesBySubadresAsync(ListAdrespositiesBySubadresRequest request);
        Task<ListGebouwenByHuisnummerResponse> ListGebouwenByHuisnummerAsync(ListGebouwenByHuisnummerRequest request);
        Task<ListHuisnummersByIdentificatorTerreinobjectResponse> ListHuisnummersByIdentificatorTerreinobjectAsync(ListHuisnummersByIdentificatorTerreinobjectRequest request);
        Task<ListHuisnummersWithStatusByIdentificatorGebouwResponse> ListHuisnummersWithStatusByIdentificatorGebouwAsync(ListHuisnummersWithStatusByIdentificatorGebouwRequest request);
        Task<ListHuisnummersWithStatusByIdentificatorPerceelResponse> ListHuisnummersWithStatusByIdentificatorPerceelAsync(ListHuisnummersWithStatusByIdentificatorPerceelRequest request);
        Task<ListHuisnummersWithStatusByIdentificatorTerreinobjectResponse> ListHuisnummersWithStatusByIdentificatorTerreinobjectAsync(ListHuisnummersWithStatusByIdentificatorTerreinobjectRequest request);
        Task<ListPercelenByHuisnummerResponse> ListPercelenByHuisnummerAsync(ListPercelenByHuisnummerRequest request);
        Task<ListRijksregisterAdresByHuisnummerResponse> ListRijksregisterAdresByHuisnummerAsync(ListRijksregisterAdresByHuisnummerRequest request);
        Task<ListStraatnamenByIdentificatorWegobjectResponse> ListStraatnamenByIdentificatorWegobjectAsync(ListStraatnamenByIdentificatorWegobjectRequest request);
        Task<ListStraatnamenWithStatusByIdentificatorWegobjectResponse> ListStraatnamenWithStatusByIdentificatorWegobjectAsync(ListStraatnamenWithStatusByIdentificatorWegobjectRequest request);
        Task<ListStraatnamenWithStatusByIdentificatorWegsegmentResponse> ListStraatnamenWithStatusByIdentificatorWegsegmentAsync(ListStraatnamenWithStatusByIdentificatorWegsegmentRequest request);



        Task<AdrespositieObject> GetAdrespositieByAdrespositieIdAsync(int AdrespositieId);
        //Task<GemeenteObject> GetGemeenteByGemeenteIdAsync(int GemeenteId);
        Task<GemeenteObject> GetGemeenteByNISGemeenteCodeAsync(int NISGemeenteCode);
        Task<HuisnummerObject> GetHuisnummerByHuisnummerIdAsync(int HuisnummerId);
        Task<HuisnummerWithStatusObject> GetHuisnummerWithStatusByHuisnummerIdAsync(int HuisnummerId);
        Task<PostadresObject> GetPostadresByHuisnummerIdAsync(int HuisnummerId);
        Task<PostadresObject> GetPostadresBySubadresIdAsync(int SubadresId);
        Task<PostkantonObject> GetPostkantonByHuisnummerIdAsync(int HuisnummerId);
        Task<RijksregisterstraatObject> GetRijksregisterStraatByRijksregisterStraatCodeAsync(int StraatCode, int SubkantonCode);
        Task<StraatnaamObject> GetStraatnaamByRijksregisterStraatCodeAsync(int StraatCode, int SubkantonCode);
        //Task<StraatnaamObject> GetStraatnaamByStraatnaamIdAsync(int StraatnaamId);
        Task<StraatnaamWithStatusObject> GetStraatnaamWithStatusByRijksregisterStraatCodeAsync(int StraatCode, int SubkantonCode);
        //Task<StraatnaamWithStatusObject> GetStraatnaamWithStatusByStraatnaamIdAsync(int StraatnaamId);
        Task<SubadresObject> GetSubadresBySubadresIdAsync(int SubadresId);
        Task<SubadresWithStatusObject> GetSubadresWithStatusBySubadresIdAsync(int SubadresId);
        Task<CodeItem[]> ListAardAdressenAsync(int SorteerVeld);
        Task<CodeItem[]> ListAardGebouwenAsync(int SorteerVeld);
        Task<CodeItem[]> ListAardSubadressenAsync(int SorteerVeld);
        Task<CodeItem[]> ListAardTerreinobjectenAsync(int SorteerVeld);
        Task<CodeItem[]> ListAardWegobjectenAsync(int SorteerVeld);
        Task<AdrespositieItem[]> ListAdrespositiesByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);
        Task<AdrespositieItem[]> ListAdrespositiesBySubadresIdAsync(int SubadresId, int SorteerVeld);
        Task<CodeItem[]> ListBewerkingenAsync(int SorteerVeld);
        Task<GebouwItem[]> ListGebouwenByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);
        //Task<GemeenteItem[]> ListGemeentenByGewestIdAsync(int GewestId, int SorteerVeld);
        Task<CodeItem[]> ListGeometriemethodeGebouwenAsync(int SorteerVeld);
        Task<CodeItem[]> ListGeometriemethodeWegsegmentenAsync(int SorteerVeld);
        //Task<GewestItem[]> ListGewestenAsync(int SorteerVeld);
        Task<CodeItem[]> ListHerkomstAdrespositiesAsync(int SorteerVeld);
        //Task<HuisnummerItem[]> ListHuisnummersByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld);
        Task<HuisnummerWithStatusItem[]> ListHuisnummersWithStatusByRijksregisterAdresIdAsync(int RijksregisterAdresId, int SorteerVeld);
        //Task<HuisnummerWithStatusItem[]> ListHuisnummersWithStatusByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld);
        Task<CodeItem[]> ListOrganisatiesAsync(int SorteerVeld);
        Task<PerceelItem[]> ListPercelenByHuisnummerIdAsync(int HuisnummerId);
        //Task<PostadresItem[]> ListPostadressenByStraatnaamIdAsync(int StraatnaamId);
        //Task<PostkantonItem[]> ListPostkantonsByGemeenteIdAsync(int GemeenteId);
        Task<RijksregisterstraatItem[]> ListRijksregisterStratenByStraatnaamIdAsync(int StraatnaamId);
        Task<RijksregisterAdresItem[]> ListRijksregisterAdresByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);
        Task<RijksregisterAdresItem[]> ListRijksregisterAdresBySubadresIdAsync(int SubadresId, int SorteerVeld);
        //Task<CodeItem[]> ListStatusGebouwenAsync(int SorteerVeld);
        //Task<CodeItem[]> ListStatusHuisnummersAsync(int SorteerVeld);
        //Task<CodeItem[]> ListStatusStraatnamenAsync(int SorteerVeld);
        //Task<CodeItem[]> ListStatusSubadressenAsync(int SorteerVeld);
        //Task<CodeItem[]> ListStatusWegsegmentenAsync(int SorteerVeld);
        //Task<StraatnaamItem[]> ListStraatnamenByGemeenteIdAsync(int GemeenteId, int SorteerVeld);
        //Task<StraatnaamWithStatusItem[]> ListStraatnamenWithStatusByGemeenteIdAsync(int GemeenteId, int SorteerVeld);
        Task<SubadresItem[]> ListSubadressenByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);
        Task<SubadresWithStatusItem[]> ListSubadressenWithStatusByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);
        Task<SubadresWithStatusItem[]> ListSubadressenWithStatusByRijksregisterAdresIdAsync(int RijksregisterAdresId,int SorteerVeld);
        //Task<CodeItem[]> ListTalenAsync(int SorteerVeld);
        Task<TerreinobjectItem[]> ListTerreinobjectenByHuisnummerIdAsync(int HuisnummerId, int SorteerVeld);
        //Task<WegobjectItem[]> ListWegobjectenByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld);
        //Task<WegsegmentItem[]> ListWegsegmentenByStraatnaamIdAsync(int StraatnaamId, int SorteerVeld);
    }
}