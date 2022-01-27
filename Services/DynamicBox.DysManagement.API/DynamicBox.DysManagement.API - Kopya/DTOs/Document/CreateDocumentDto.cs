using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.API.DTOs.Document
{
    public class CreateDocumentDto
    {
       
        #region Document table
        public long Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Döküman adı boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "Döküman adı en fazla 100 karakter olabilir.")]
        public string DocumentName { get; set; } = null!;


        [Required(AllowEmptyStrings = false, ErrorMessage = "Döküman tipi boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "Döküman tipi en fazla 100 karakter olabilir.")]
        public string DocumentType { get; set; } = null!;


        [StringLength(maximumLength:100, ErrorMessage = "Evrak gönderen en fazla 100 karakter girilebilir")]
        public string? FromPlace { get; set; }


        [StringLength(maximumLength:100, ErrorMessage ="Doküman numarası en fazla 100 karakter girilebilir")]
        public string? DocumentNumber { get; set; }


        public DateTime? DocumentDate { get; set; }


        public string? FilePath { get; set; }
        #endregion


        public AuthorDto Author { get; set; } = null!;
    }
}
