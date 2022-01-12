using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.API.DTOs.Document
{
    public class CreateDocumentDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Döküman adı boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "Döküman adı en fazla 100 karakter olabilir.")]
        public string DocumentName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Şirket kodu alanı boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "Şirket kodu alanı boş bırakılamaz.")]
        public string BusinessCode { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Çalıştırılacak iş akışı ID numarası zorunludur. (WorkflowDefinationId)")]
        [StringLength(maximumLength: 100, ErrorMessage = "Çalıştırılacak iş akışı ID numarası zorunludur. (WorkflowDefinationId)")]
        public string WorkflowDefinationId { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Döküman tipi zorunludur.")]
        [StringLength(maximumLength: 100, ErrorMessage = "Döküman tipi zorunludur.")]
        public string DocumentType { get; set; }


        public AuthorDto Author { get; set; }
    }
}
