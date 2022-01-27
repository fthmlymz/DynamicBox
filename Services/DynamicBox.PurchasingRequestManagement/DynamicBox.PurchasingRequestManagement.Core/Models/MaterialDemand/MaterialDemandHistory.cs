namespace DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand
{
    public class MaterialDemandHistory : BaseEntity
    {

        public string DefinationId { get; set; }
        public string TenantId { get; set; }
        public int Version { get; set; }
        public int WorkflowStatus { get; set; }
        public string CorrelationId { get; set; }
        public string ContextType { get; set; }
        public string ContextId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastExecutedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public DateTime CancelledAt { get; set; }
        public DateTime FaultedAt { get; set; }
        public string Data { get; set; }
        public string LastExecutedActivityId { get; set; }
        public string DefinationVersionId { get; set; }



        public long MaterialDemandId { get; set; }
        public MaterialDemand MaterialDemand { get; set; }
    }
}
