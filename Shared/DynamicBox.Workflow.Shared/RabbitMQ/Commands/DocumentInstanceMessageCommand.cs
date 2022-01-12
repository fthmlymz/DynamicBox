using System;

namespace DynamicBox.Workflow.Shared.RabbitMQ.Commands
{
    public class DocumentInstanceMessageCommand
    {
        public long Id { get; set; }
        public string DefinitionId { get; set; }
        public string DefinitionVersionId { get; set; }
        public string TenantId { get; set; }
        public long? Version { get; set; }
        public string WorkflowStatus { get; set; }
        public string CorrelationId { get; set; }
        public string ContextType { get; set; }
        public string ContextId { get; set; }
        public string Name { get; set; }
        

        public DateTime? CreatedAt { get; set; }
        public DateTime? LastExecutedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public DateTime? CancelledAt { get; set; }
        public DateTime? FaultedAt { get; set; }
    }
}
