using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.API.DTOs.Document
{
    public class AuthorDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Dökümanı oluşturan kullanıcı alanı boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "Dökümanı oluşturan kullanıcı alanı boş bırakılamaz.")]
        public string AuthorName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Dökümanı oluşturan e-mail alanı boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "Dökümanı oluşturan e-mail alanı boş bırakılamaz.")]
        public string AuthorEmail { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Dökümanı oluşturan yayınlayan AuthorUserId alanı boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "Dökümanı oluşturan kullanıcı alanı boş bırakılamaz.")]
        public string AuthorUserId { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Şirket birimi alanı boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "Şirket birimi alanı boş bırakılamaz.")]
        public string BusinessUnit { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "İlk onaylayıcı alanı boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "İlk onaylayıcı alanı en fazla 100 karakter girilebilir.")]
        public string FirstApprove { get; set; }
    }
}
