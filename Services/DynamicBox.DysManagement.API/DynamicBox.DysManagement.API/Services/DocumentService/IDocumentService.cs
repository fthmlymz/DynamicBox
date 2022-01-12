using DynamicBox.DysManagement.API.DTOs.Document;
using DynamicBox.Workflow.Shared.Dtos;
using DynamicBox.Workflow.Shared.RabbitMQ.Commands;

namespace DynamicBox.DysManagement.API.Services.DocumentService
{
    public interface IDocumentService
    {
        public Task<ServiceResponse<CreateDocumentDto>> AddDocument(CreateDocumentDto createDocument);
        public Task<ServiceResponse<List<GetDocumentDto>>> GetDocumentDto();
        public Task<ServiceResponse<NoContent>> UpdateDocument(UpdateDocumentDto updateDocument);
        public Task<ServiceResponse<NoContent>> DeleteDocument(long Id);

        public Task<ServiceResponse<NoContent>> SignalExecute(SignalExecuteMessageCommand signalExecute);
    }
}
