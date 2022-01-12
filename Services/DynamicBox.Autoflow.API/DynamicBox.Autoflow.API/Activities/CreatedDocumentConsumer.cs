using Autoflow.ActivityResults;
using Autoflow.Services;
using Autoflow.Services.Models;
using DynamicBox.Workflow.Shared.RabbitMQ;
using DynamicBox.Workflow.Shared.RabbitMQ.Commands;
using MassTransit;

namespace DynamicBox.Autoflow.API.Activities
{

    public class CreatedDocumentConsumer : Activity, IConsumer<CreatedDocumentMessageCommand>
    {
        private readonly IWorkflowLaunchpad _workflowLaunchpad;
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public CreatedDocumentConsumer(IWorkflowLaunchpad workflowLaunchpad, ISendEndpointProvider sendEndpointProvider)
        {
            _workflowLaunchpad = workflowLaunchpad;
            _sendEndpointProvider = sendEndpointProvider;
        }


        //created-document okunduktan hemen sonra İş akışını çalıştır.
        public async Task Consume(ConsumeContext<CreatedDocumentMessageCommand> context)
        {
            Console.WriteLine($"Consume çalıştı {context.Message}");
            var sendEndpointSuccess = await _sendEndpointProvider.GetSendEndpoint(new Uri($"queue:{RabbitMQSettingsConst.ExecutedDocumentSuccess}"));
            var sendEndpointFail = await _sendEndpointProvider.GetSendEndpoint(new Uri($"queue:{RabbitMQSettingsConst.ExecutedDocumentFail}"));
            try
            {
                var startableWorkflow = await _workflowLaunchpad.FindStartableWorkflowAsync(context.Message.WorkFlowDefinationId);
                var result = await _workflowLaunchpad.ExecuteStartableWorkflowAsync(startableWorkflow);
                //Console.WriteLine(result.WorkflowInstance.DefinitionId);
                //RabbitMQ üzerinde eğer created-message 
                var documentInstanceSuccess = new DocumentInstanceMessageCommand
                {
                    DefinitionId = result.WorkflowInstance.DefinitionId,
                    TenantId = result.WorkflowInstance.TenantId,
                    Version = result.WorkflowInstance.Version,
                    WorkflowStatus = result.WorkflowInstance.WorkflowStatus.ToString(),
                    CorrelationId = result.WorkflowInstance.CorrelationId,
                    ContextType = result.WorkflowInstance.ContextType,
                    ContextId = result.WorkflowInstance.ContextId,
                    Name = result.WorkflowInstance.Name,
                    CreatedAt = Convert.ToDateTime(result.WorkflowInstance.CreatedAt),
                    LastExecutedAt = Convert.ToDateTime(result.WorkflowInstance.LastExecutedAt),
                    FinishedAt = Convert.ToDateTime(result.WorkflowInstance.FinishedAt),
                    CancelledAt = Convert.ToDateTime(result.WorkflowInstance.CancelledAt),
                    FaultedAt = Convert.ToDateTime(result.WorkflowInstance.FaultedAt),
                    DefinitionVersionId = result.WorkflowInstance.DefinitionVersionId
                };
                await sendEndpointSuccess.Send<DocumentInstanceMessageCommand>(documentInstanceSuccess);
            }
            catch (Exception e)
            {
                //var documentInstanceFail = new DocumentInstanceMessageCommand
                //{
                //    DefinitionId = result.WorkflowInstance.DefinitionId,
                //    TenantId = result.WorkflowInstance.TenantId,
                //    Version = result.WorkflowInstance.Version,
                //    WorkflowStatus = result.WorkflowInstance.WorkflowStatus.ToString(),
                //    CorrelationId = result.WorkflowInstance.CorrelationId,
                //    ContextType = result.WorkflowInstance.ContextType,
                //    ContextId = result.WorkflowInstance.ContextId,
                //    Name = result.WorkflowInstance.Name,
                //    CreatedAt = Convert.ToDateTime(result.WorkflowInstance.CreatedAt),
                //    LastExecutedAt = Convert.ToDateTime(result.WorkflowInstance.LastExecutedAt),
                //    FinishedAt = Convert.ToDateTime(result.WorkflowInstance.FinishedAt),
                //    CancelledAt = Convert.ToDateTime(result.WorkflowInstance.CancelledAt),
                //    FaultedAt = Convert.ToDateTime(result.WorkflowInstance.FaultedAt),
                //    DefinitionVersionId = result.WorkflowInstance.DefinitionVersionId
                //};
            }

        }

        protected override async ValueTask<IActivityExecutionResult> OnExecuteAsync(ActivityExecutionContext context)
        {
            Console.WriteLine("OnExecuteAsync alanı çalıştı.");





            return Done();



            //return Done();
            //var busControl = Bus.Factory.CreateUsingRabbitMq();
            //var httpEndpointContext = JsonConvert.DeserializeObject<dynamic>(((Elsa.Activities.Http.Models.HttpRequestModel)context.WorkflowExecutionContext.Input).RawBody);


            //#region RabbitMQ - Change document notify command
            //try
            //{
            //    await busControl.StartAsync(new CancellationTokenSource(TimeSpan.FromSeconds(Convert.ToDouble(Configuration["RabbitMQ:Timeout"]))).Token).ConfigureAwait(false);
            //    var sendEndpoint = await busControl.GetSendEndpoint(new Uri("queue:change-document"));

            //    var changedDocument = new CreateDocumentMessageCommand();
            //    changedDocument.InstanceId = httpEndpointContext.workflowInstanceId;
            //    changedDocument.CorrelationId = httpEndpointContext.correlationId;
            //    changedDocument.SignalName = ((Elsa.Activities.Signaling.Models.Signal)context.WorkflowExecutionContext.Input).SignalName;

            //    await sendEndpoint.Send<CreateDocumentMessageCommand>(changedDocument);

            //    return Done(Outcomes(changedDocument));
            //}
            //catch (MassTransitException e)
            //{
            //    return Fault(e);
            //}
            //finally
            //{
            //    await busControl.StopAsync();
            //}
            //#endregion
        }
    }
}
