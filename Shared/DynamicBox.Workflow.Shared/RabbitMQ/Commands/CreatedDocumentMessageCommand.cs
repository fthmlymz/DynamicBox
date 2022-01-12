using System;

namespace DynamicBox.Workflow.Shared.RabbitMQ.Commands
{
    public class CreatedDocumentMessageCommand
    {
        public long Id { get; set; }
        public string WorkFlowDefinationId { get; set; }
        public string CorrelationId { get; set; }
        public string DefinationId { get; set; }
        public string InstanceId { get; set; }
        public int? Version { get; set; }
        public string SignalName { get; set; }


        public string DocumentType { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DocumentName { get; set; }
        public Guid DocumentCode { get; set; }
        public string BusinessCode { get; set; }
        public Author Author { get; set; } = new Author();
    }

    public class Author
    {
        public string AuthorUserId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string FirstApprove { get; set; }
        public string BusinessUnit { get; set; }
    }
}
