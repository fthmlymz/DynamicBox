using AutoMapper;
using DynamicBox.DysManagement.API.DTOs.Document;
using DynamicBox.DysManagement.API.Models;

namespace DynamicBox.Workflow.DysManagement.API
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Document, CreateDocumentDto>().ReverseMap();
            CreateMap<Document, UpdateDocumentDto>().ReverseMap();
            CreateMap<Document, GetDocumentDto>().ReverseMap();



        }
    }
}
