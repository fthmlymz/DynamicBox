using DynamicBox.DysManagement.API.Data;
using DynamicBox.DysManagement.API.Models;
using DynamicBox.Workflow.Shared;
using DynamicBox.Workflow.Shared.RabbitMQ.Commands;
using MassTransit;
using Microsoft.EntityFrameworkCore;

namespace DynamicBox.Workflow.DysManagement.API.Consumers
{
    public class CreatedDocumentConsumer : IConsumer<CreatedDocumentMessageCommand>
    {
        private readonly DataContext _context;


        public CreatedDocumentConsumer(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task Consume(ConsumeContext<CreatedDocumentMessageCommand> context)
        {
            Console.WriteLine("iş akışı çalıştı ve iş akışı tarafı güncellendi. DYS tarafı çalışıyor şuanda ");


            Document document = await _context.Documents.FirstOrDefaultAsync(c => c.Id == context.Message.Id);

            if (document == null)
            {
                Console.WriteLine("güncellenecek işlem bulunamadı");
            }

            try
            {
                document.Status = "Suspended";
                document.CorrelationId = context.Message.CorrelationId.GetValueOrDefault(context.Message.CorrelationId);
                document.WorkflowDefinationId = context.Message.DefinationId.GetValueOrDefault(context.Message.WorkFlowDefinationId);
                document.InstanceId = context.Message.InstanceId.GetValueOrDefault(context.Message.InstanceId);
                document.SignalName = context.Message.SignalName.GetValueOrDefault(context.Message.SignalName);
                document.Version = context.Message.Version.GetValueOrDefault((int)context.Message.Version);

                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
