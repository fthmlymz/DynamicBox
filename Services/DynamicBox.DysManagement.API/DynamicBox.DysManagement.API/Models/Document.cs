using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicBox.DysManagement.API.Models
{
    public class Document
    {
        public long Id { get; set; }


        [StringLength(maximumLength: 150)]
        public string CorrelationId { get; set; }


        [StringLength(maximumLength: 150)]
        public string WorkflowDefinationId { get; set; }


        [StringLength(maximumLength: 150)]
        public string InstanceId { get; set; }


        public int? Version { get; set; }
        public string SignalName { get; set; }




        //Postman ile bu alanları gönder
        [StringLength(maximumLength: 100)]
        public string DocumentName { get; set; }


        [StringLength(maximumLength: 100)]
        public string DocumentType { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DocumentCode { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string BusinessCode { get; set; }

        [StringLength(maximumLength: 100)]
        public string BusinessUnit { get; set; }

        [DefaultValue(typeof(DateTime))]
        public DateTime? CreatedDate { get; set; }


        [Timestamp]
        public byte[] Timestamp { get; set; }


        [Required]
        [StringLength(maximumLength: 100)]
        public string AuthorUserId { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string AuthorName { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string AuthorEmail { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string FirstApprove { get; set; }

        [StringLength(maximumLength: 100)]
        public string Status { get; set; }
    }
}
