using AutoMapper;
using DynamicBox.DysManagement.Core.DTOs.Company.CompanyInformation;
using DynamicBox.DysManagement.Core.DTOs.Company.SubCompany;
using DynamicBox.DysManagement.Core.DTOs.Documents.Document;
using DynamicBox.DysManagement.Core.DTOs.Documents.DocumentInstance;
using DynamicBox.DysManagement.Core.Models.Company;
using DynamicBox.DysManagement.Core.Models.Document;

namespace DynamicBox.DysManagement.Services.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Company DTO
            CreateMap<CompanyInformation, CompanyInformationGetDto>().ReverseMap();
            CreateMap<CompanyInformation, CompanyInformationCreateDto>().ReverseMap();
            CreateMap<CompanyInformation, CompanyInformationUpdateDto>().ReverseMap();
            #endregion

            #region Sub company
            CreateMap<SubCompanie, SubCompanieGetDto>().ReverseMap();
            CreateMap<SubCompanie, SubCompanieCreateDto>().ReverseMap();
            CreateMap<SubCompanie, SubCompanieUpdateDto>().ReverseMap();
            #endregion


            #region Document
            CreateMap<Document, DocumentCreateDto>().ReverseMap();
            CreateMap<Document, DocumentGetDto>().ReverseMap();
            CreateMap<Document, DocumentUpdateDo>().ReverseMap();
            #endregion


            #region Document Instance
            CreateMap<DocumentInstance, DocumentInstanceCreateDto>().ReverseMap();
            CreateMap<DocumentInstance, DocumentInstanceUpdateDto>().ReverseMap();
            CreateMap<DocumentInstance, DocumentInstanceGetDto>().ReverseMap();
            #endregion
        }
    }
}
