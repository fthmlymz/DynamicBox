using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.API.DTOs.Document
{
    public class AuthorDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "AuthorUserId  boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "AuthorUserId en fazla 100 karakter olabilir.")]
        public string AuthorUserId { get; set; } = null!;


        [StringLength(maximumLength: 100, ErrorMessage = "AuthorName en fazla 100 karakter olabilir.")]
        public string? AuthorName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "AuthorEmail boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "AuthorEmail en fazla 100 karakter olabilir.")]
        public string AuthorEmail { get; set; } = null!;


        [Required(AllowEmptyStrings = false, ErrorMessage = "BusinessCode boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "BusinessCode en fazla 100 karakter olabilir.")]
        public string BusinessCode { get; set; } = null!;



        [Required(AllowEmptyStrings = false, ErrorMessage = "BusinessUnit boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "BusinessUnit en fazla 100 karakter olabilir.")]
        public string BusinessUnit { get; set; } = null!;


        [Required(AllowEmptyStrings = false, ErrorMessage = "FirstApproveMail boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "FirstApproveMail en fazla 100 karakter olabilir.")]
        public string FirstApproveMail { get; set; } = null!;



        [Required(AllowEmptyStrings = false, ErrorMessage = "FirstApproveUserId boş bırakılamaz.")]
        [StringLength(maximumLength: 100, ErrorMessage = "FirstApproveUserId en fazla 100 karakter olabilir.")]
        public string? FirstApproveUserId { get; set; }
    }
}
