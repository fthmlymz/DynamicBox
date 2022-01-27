using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicBox.DysManagement.Core.Models.Document
{
    public class Document
    {

        #region Document table
        public long Id { get; set; }


        [StringLength(maximumLength: 100)]
        public string DocumentName { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string DocumentType { get; set; } = null!;  //Evrak tipi (gelen, giden, resmi yazışma, botaş


        [StringLength(maximumLength: 100)]
        public string? FromPlace { get; set; } //Evrak nereden geldi

        [StringLength(maximumLength: 100)]
        public string? DocumentNumber { get; set; }  //Evrak numarası

        public DateTime? DocumentDate { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DocumentCode { get; set; }

        [StringLength(maximumLength: 50)]
        public string? Status { get; set; }
        public string? FilePath { get; set; }
        #endregion




        #region Document table author detail
        [StringLength(maximumLength: 100)]
        public string AuthorEmail { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string FirstApproveMail { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string? FirstApproveUserId { get; set; }
        #endregion





        #region Relationship
        ////İlişkilendirme
        ////Hangi kuruma aitse ilişkilendir one many
        ////public Company.CompanyInformation? CompanyInformation { get; set; }
        //public Company.SubCompanie? SubCompanie { get; set; }

        
        ////Birden fazla document instance bilgisi olabilir.
        //public ICollection<DocumentInstance>? DocumentInstances { get; set; } 
        #endregion
    }
}
