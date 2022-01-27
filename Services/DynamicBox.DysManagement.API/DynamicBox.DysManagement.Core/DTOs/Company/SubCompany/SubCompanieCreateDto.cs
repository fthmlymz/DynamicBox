using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.Core.DTOs.Company.SubCompany
{
    public class SubCompanieCreateDto
    {
        [StringLength(maximumLength: 100)]
        public string SubCompanyName { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string? SubCompanyDescription { get; set; }


        [StringLength(maximumLength: 100)]
        public string? SubCompanyPhone { get; set; }


        [StringLength(maximumLength: 100)]
        public string? SubCompanyAddress { get; set; }


        [StringLength(maximumLength: 100)]
        public string? SubCompanyCity { get; set; }


        [StringLength(maximumLength: 100)]
        public string? SubCompanyRegion { get; set; }



        [StringLength(maximumLength: 100)]
        public string BusinessCode { get; set; } = null!;


        public DateTime? CreatedDate { get; set; }


        public long CompanyInformationId { get; set; }

        // public ICollection<Models.Document.Document> Documents { get; set; } = null!;
        //public Models.Company.CompanyInformation CompanyInformations { get; set; } = null!;
    }
}
