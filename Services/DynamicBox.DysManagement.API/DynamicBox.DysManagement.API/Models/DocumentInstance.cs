using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.API.Models
{
    public class DocumentInstance
    {
        public long Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string DefinitionId { get; set; } = default!;

        [StringLength(maximumLength: 100)]
        public string DefinitionVersionId { get; set; } = default!;

        [StringLength(maximumLength: 100)]
        public string TenantId { get; set; }


        public long? Version { get; set; }


        [StringLength(maximumLength: 50)]
        public string WorkflowStatus { get; set; }

        [StringLength(maximumLength: 100)]
        public string CorrelationId { get; set; } = default!;

        [StringLength(maximumLength: 100)]
        public string ContextType { get; set; }


        [StringLength(maximumLength: 100)]
        public string ContextId { get; set; }

        [StringLength(maximumLength: 100)]
        public string Name { get; set; }


        public DateTime? CreatedAt { get; set; }
        public DateTime? LastExecutedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public DateTime? CancelledAt { get; set; }
        public DateTime? FaultedAt { get; set; }
    }
}
