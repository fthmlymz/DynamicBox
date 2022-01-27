using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicBox.DysManagement.API.Models
{
    public class Document
    {
        #region Document table
        public long Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string DocumentName { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string DocumentType { get; set; } = null!;  //Evrak tipi (gelen, giden, resmi yazışma, botaş


        [StringLength(maximumLength:100)]
        public string FromPlace { get; set; } //Evrak nereden geldi

        [StringLength(maximumLength:100)]
        public string DocumentNumber { get; set; }  //Evrak numarası

        public DateTime? DocumentDate { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DocumentCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [StringLength(maximumLength: 50)]
        public string? Status { get; set; }
        public string? FilePath { get; set; }
        #endregion




        #region Document table author detail
        [StringLength(maximumLength: 100)]
        public string AuthorUserId { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string? AuthorName { get; set; }


        [StringLength(maximumLength: 100)]
        public string AuthorEmail { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string BusinessCode { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string BusinessUnit { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string FirstApproveMail { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string? FirstApproveUserId { get; set; }
        #endregion


        public ICollection<DocumentInstance> DocumentInstances { get; set; }



        public Document()
        {
            this.CreatedDate = DateTime.Now;
            this.UpdatedDate = DateTime.Now;
        }
    }


}
