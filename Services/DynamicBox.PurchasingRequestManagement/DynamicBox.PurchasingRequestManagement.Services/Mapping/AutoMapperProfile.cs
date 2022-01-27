using AutoMapper;
using DynamicBox.PurchasingManagement.Core.DTOs.Company;
using DynamicBox.PurchasingManagement.Core.Models.Company;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Company;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemandDetail;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;

namespace DynamicBox.PurchasingManagement.Services.Mapping
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            #region Company
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<Company, CompanyWithMaterialDemandsDto>().ReverseMap();
            #endregion


            #region MaterialList
            CreateMap<MaterialList, MaterialListDto>().ReverseMap();
            #endregion


            #region MaterialDemand
            CreateMap<MaterialDemand, MaterialDemandDto>().ReverseMap();
            CreateMap<MaterialDemand, MaterialDemandDetailDto>().ReverseMap();
            CreateMap<MaterialDemand, MaterialDemandWithCompanyDto>().ReverseMap(); //MaterialDemandWithCompanyDto
            CreateMap<MaterialDemand, MaterialDemandsWithDetailsDto>().ReverseMap();
            #endregion


            #region MaterialRequirementList
            CreateMap<MaterialDemandDetail, MaterialDemandDetailDto>().ReverseMap();
            #endregion
        }


    }
}
