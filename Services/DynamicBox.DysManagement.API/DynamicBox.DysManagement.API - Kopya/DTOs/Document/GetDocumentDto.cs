using DynamicBox.DysManagement.API.DTOs.DocumentInstance;
using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.API.DTOs.Document
{
    public class GetDocumentDto
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "AuthorUserId alanı boş bırakılamaz")]
        public string AuthorUserId { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Şirket kodu alanı boş bırakılamaz")]
        public string BusinessCode { get; set; } = null!;


        public ICollection<GetDocumentInstanceDto>? GetDocumentInstances { get; set; }
    }
}
