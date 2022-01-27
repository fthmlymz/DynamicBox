using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.Core.DTOs.Documents.Document
{
    public class DocumentUpdateDo
    {
        #region Document table
        [StringLength(maximumLength: 100)]
        public string DocumentName { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string DocumentType { get; set; } = null!;  //Evrak tipi (gelen, giden, resmi yazışma, botaş


        [StringLength(maximumLength: 100)]
        public string? FromPlace { get; set; } //Evrak nereden geldi

        [StringLength(maximumLength: 100)]
        public string? DocumentNumber { get; set; }  //Evrak numarası

        public DateTime? DocumentDate { get; set; }


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
    }
}
