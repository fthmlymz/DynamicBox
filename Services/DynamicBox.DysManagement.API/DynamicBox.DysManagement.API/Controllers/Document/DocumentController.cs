using DynamicBox.DysManagement.API.DTOs.Document;
using DynamicBox.DysManagement.API.Services.DocumentService;
using DynamicBox.Workflow.Shared.RabbitMQ.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBox.DysManagement.API.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDocument(CreateDocumentDto documentCreate)
        {
            var document = await _documentService.AddDocument(documentCreate);

            return Ok(document);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateDocument(UpdateDocumentDto documentUpdate)
        {
            var doc = await _documentService.UpdateDocument(documentUpdate);
            return Ok(doc);
        }


        [Route("[controller]/[action]")]
        [HttpPost]
        public async Task<IActionResult> SignalExecute(SignalExecuteMessageCommand signalExecute)
        {
            var signal = await _documentService.SignalExecute(signalExecute);
            return Ok(signal);
        }
    }
}
