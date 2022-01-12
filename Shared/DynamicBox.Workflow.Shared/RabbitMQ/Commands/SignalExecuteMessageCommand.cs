namespace DynamicBox.Workflow.Shared.RabbitMQ.Commands
{
    public class SignalExecuteMessageCommand
    {
        public string WorkflowInstanceId { get; set; }
        public string CorrelationId { get; set; }
        public string Input { get; set; }
    }
}
