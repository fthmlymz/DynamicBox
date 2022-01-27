using DynamicBox.DysManagement.API.DTOs.Document;
using DynamicBox.DysManagement.API.Services.DocumentService;
using DynamicBox.Workflow.Shared.RabbitMQ.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net;

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


        [HttpGet]
        //public async Task<IActionResult> Documents(GetDocumentDto getDocument)
        public async Task<IActionResult> Documents(GetDocumentDto getDocument)
        {
            var document = await _documentService.Documents(getDocument);
            //return CreateActionResultInstance(document);



            return Ok(document);
        }


        [HttpPost]
        //public async Task<IActionResult> CreateDocument(CreateDocumentDto documentCreate)
        //[Produces("application/json")]
        public async Task<IActionResult> CreateDocument([FromBody]CreateDocumentDto documentCreate)
        {
            var document = await _documentService.AddDocument(documentCreate);
            //return Ok();

            return Ok(document);
        }



        [Route("[controller]/[action]")]
        [HttpPost]
        public async Task<IActionResult> SignalExecute(SignalExecuteMessageCommand signalExecute)
        {
            var signal = await _documentService.SignalExecute(signalExecute);
            return Ok(signal);
        }



        [HttpPut]
        //public IActionResult UpdateOwner(Guid id, [FromBody]Owner owner)
        public async Task<IActionResult> UpdateDocument(UpdateDocumentDto documentUpdate)
        {
            var doc = await _documentService.UpdateDocument(documentUpdate);
            return Ok(doc);
        }


        //[HttpDelete("{id}")]
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            return Ok(id);
        }


    }
}
