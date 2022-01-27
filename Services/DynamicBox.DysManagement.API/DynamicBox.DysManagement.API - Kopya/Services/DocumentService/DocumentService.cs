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
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public DocumentService(IMapper mapper, DataContext context, ISendEndpointProvider sendEndpointProvider, ILogger<DocumentService> logger)
        {
            _mapper = mapper;
            _context = context;
            _sendEndpointProvider = sendEndpointProvider;
            _logger = logger;
        }

        public async Task<IEnumerable<GetDocumentDto>> Documents(GetDocumentDto getDocument)
        {
            var documentList = await _context.Documents.Where(c => c.AuthorUserId == getDocument.AuthorUserId)
                                                       .Where(c => c.BusinessCode == getDocument.BusinessCode)
                                                       .Select(c => _mapper.Map<GetDocumentDto>(c))
                                                       .ToListAsync();

            //Doküman yoksa NoContent olarak geri dön
            //if (!documentList.Any())
            //{
            //    return ServiceResponse<List<GetDocumentDto>>.Fail("İçerik boş", 204);
            //}

            return _mapper.Map<IEnumerable<GetDocumentDto>>(documentList); //ServiceResponse<List<GetDocumentDto>>.Success(_mapper.Map<List<GetDocumentDto>>(documentList), 200);
        }


        public async Task<IAsyncEnumerable<CreateDocumentDto>> AddDocument(CreateDocumentDto createDocument)
        {
            //var sendEndpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:deneme"));


            Document document = _mapper.Map<Document>(createDocument);

            document.DocumentName = createDocument.DocumentName;
            document.DocumentType = createDocument.DocumentType;
            document.DocumentCode = Guid.NewGuid();
            document.Status = "Idle";
            document.FilePath = createDocument.FilePath;
            document.AuthorUserId = createDocument.Author.AuthorUserId;
            document.AuthorName = createDocument.Author.AuthorName;
            document.AuthorEmail = createDocument.Author.AuthorEmail;
            document.BusinessCode = createDocument.Author.BusinessCode;
            document.BusinessUnit = createDocument.Author.BusinessUnit;
            document.FirstApproveMail = createDocument.Author.FirstApproveMail;
            document.FirstApproveUserId = createDocument.Author.FirstApproveUserId;

            _context.Documents.Add(document);
            await _context.SaveChangesAsync();

            //await sendEndpoint.Send<CreatedDocumentMessageCommand>(document);

            //return _mapper.Map<IEnumerable<CreateDocumentDto>>(document);//_mapper.Map<IEnumerable<CreateDocumentDto>>(document);
            //return _mapper.Map<IEnumerable<Document>, IEnumerable<CreateDocumentDto>>(document);
            //return _mapper.Map<List<CreateDocumentDto>>(document);

            //return _mapper.Map<CreateDocumentDto>(document); //calısıyor
            return _mapper.Map<IAsyncEnumerable<CreateDocumentDto>>(document);
        }



        public async Task<ServiceResponse<NoContent>> UpdateDocument(UpdateDocumentDto updateDocument)
        {
            return ServiceResponse<NoContent>.Success(204);
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
