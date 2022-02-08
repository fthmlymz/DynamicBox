using AutoMapper;
using DynamicBox.PurchasingManagement.Core.DTOs.Company;
using DynamicBox.PurchasingManagement.Core.Models.Company;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Company;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemandDetail;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Product;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Models.Product;

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



            #region MaterialDemand
            CreateMap<MaterialDemand, MaterialDemandDto>().ReverseMap();
            CreateMap<MaterialDemand, MaterialDemandDetailDto>().ReverseMap();
            CreateMap<MaterialDemand, MaterialDemandWithCompanyDto>().ReverseMap(); //MaterialDemandWithCompanyDto
            CreateMap<MaterialDemand, MaterialDemandsWithDetailsDto>().ReverseMap();

            #endregion


            #region MaterialRequirementList
            CreateMap<MaterialDemandDetail, MaterialDemandDetailDto>().ReverseMap();
            #endregion


            #region Product
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, AddProductDto>().ReverseMap();
            #endregion
        }


    }
}
