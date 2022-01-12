using AutoMapper;
using DynamicBox.DysManagement.API.Data;
using DynamicBox.DysManagement.API.DTOs.Document;
using DynamicBox.DysManagement.API.Models;
using DynamicBox.Workflow.Shared.Dtos;
using DynamicBox.Workflow.Shared.RabbitMQ;
using DynamicBox.Workflow.Shared.RabbitMQ.Commands;
using MassTransit;
using Microsoft.EntityFrameworkCore;

namespace DynamicBox.DysManagement.API.Services.DocumentService
{
    public class DocumentService : IDocumentService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public DocumentService(IMapper mapper, DataContext context, ISendEndpointProvider sendEndpointProvider)
        {
            _mapper = mapper;
            _context = context;
            _sendEndpointProvider = sendEndpointProvider;
        }

        public Task<ServiceResponse<List<GetDocumentDto>>> GetDocumentDto()
        {
            throw new System.NotImplementedException();
        }


        public async Task<ServiceResponse<CreateDocumentDto>> AddDocument(CreateDocumentDto createDocument)
        {
            //Doküman ilk oluşturulduğunda aşağıdaki kuyruğa mesaj gönder
            var sendEndpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri($"queue:{RabbitMQSettingsConst.CreatedDocument}"));

            Document document = _mapper.Map<Document>(createDocument);

            try
            {
                document.DocumentName = createDocument.DocumentName;
                document.DocumentCode = Guid.NewGuid();
                document.BusinessCode = createDocument.BusinessCode;
                document.BusinessUnit = createDocument.Author.BusinessUnit;
                document.CreatedDate = DateTime.Now;
                document.AuthorUserId = createDocument.Author.AuthorUserId;
                document.AuthorName = createDocument.Author.AuthorName;
                document.AuthorEmail = createDocument.Author.AuthorEmail;
                document.FirstApprove = createDocument.Author.FirstApprove;
                document.Status = "Idle";
                document.WorkflowDefinationId = createDocument.WorkflowDefinationId;
                document.DocumentType = createDocument.DocumentType;

                _context.Documents.Add(document);
                await _context.SaveChangesAsync();



                ////RabbitMQ bildirimi yapılsın
                #region RabbitMQ -> Kuyruğuna oluşturulan doküman bilgilerini mesaj olarak gönder
                var documentCreatedCommand = new CreatedDocumentMessageCommand
                {
                    Id = document.Id,
                    WorkFlowDefinationId = document.WorkflowDefinationId,
                    DocumentType = document.DocumentType,
                    DocumentName = document.DocumentName,
                    DocumentCode = document.DocumentCode,
                    BusinessCode = document.BusinessCode,
                    CreatedDate = DateTime.Now,
                    Status = document.Status,
                    Author = new Author
                    {
                        AuthorUserId = document.AuthorUserId,
                        AuthorEmail = document.AuthorEmail,
                        AuthorName = document.AuthorName,
                        FirstApprove = document.FirstApprove,
                        BusinessUnit = document.BusinessUnit,
                    },
                };
                await sendEndpoint.Send<CreatedDocumentMessageCommand>(documentCreatedCommand);
                #endregion
            }
            catch (Exception e)
            {
                return ServiceResponse<CreateDocumentDto>.Fail($"Döküman kayıt isteği gerçekleşemedi :  {e.Message}", 400);
            }

            return ServiceResponse<CreateDocumentDto>.Success(_mapper.Map<CreateDocumentDto>(document), 200);
        }



        public async Task<ServiceResponse<NoContent>> UpdateDocument(UpdateDocumentDto updateDocument)
        {
            //"queue:document-executed-created-completed"
            return ServiceResponse<NoContent>.Success(204);
            //Document doc = await _context.Documents.FirstOrDefaultAsync(c => c.Id == updateDocument.Id);

            //if (doc == null)
            //{
            //    return ServiceResponse<NoContent>.Fail("İstek işlenemedi", 400);
            //}

            //doc.CorrelationId = updateDocument.CorrelationId.GetValueOrDefault(updateDocument.CorrelationId);
            //doc.DefinationId = updateDocument.DefinationId.GetValueOrDefault(updateDocument.DefinationId);
            //doc.InstanceId = updateDocument.InstanceId.GetValueOrDefault(updateDocument.InstanceId);
            //doc.Version = updateDocument.Version.GetValueOrDefault((int)updateDocument.Version);
            //doc.DocumentName = updateDocument.DocumentName.GetValueOrDefault(updateDocument.DocumentName);

            //doc.AuthorName = updateDocument.Author.AuthorName.GetValueOrDefault(updateDocument.Author.AuthorName);

            //await _context.SaveChangesAsync();

            //return ServiceResponse<NoContent>.Success(204);
        }
        public async Task<ServiceResponse<NoContent>> DeleteDocument(long Id)
        {
            Document document = await _context.Documents.FirstOrDefaultAsync(c => c.Id == Id);

            if (document == null)
            {
                return ServiceResponse<NoContent>.Fail("İstek bulunamadı", 400);
            }



            _context.Remove(document);
            await _context.SaveChangesAsync();

            return ServiceResponse<NoContent>.Success(200);

        }

        public async Task<ServiceResponse<NoContent>> SignalExecute(SignalExecuteMessageCommand signalExecuteMessageCommand)
        {
            var sendEndpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri($"queue:{RabbitMQSettingsConst.SignalExecute}"));

            try
            {
                var signalMessage = new SignalExecuteMessageCommand
                {
                    WorkflowInstanceId = signalExecuteMessageCommand.WorkflowInstanceId,
                    CorrelationId = signalExecuteMessageCommand.CorrelationId,
                    Input = signalExecuteMessageCommand.Input
                };
                await sendEndpoint.Send<SignalExecuteMessageCommand>(signalMessage);
            }
            catch (Exception)
            {
                return ServiceResponse<NoContent>.Fail("Onay/Red için RabbitMQ bildirimi yapılamadı", 400);
            }

            return ServiceResponse<NoContent>.Success(200);
        }


    }
}
