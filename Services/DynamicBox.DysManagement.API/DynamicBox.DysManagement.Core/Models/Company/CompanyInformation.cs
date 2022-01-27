using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.Core.Models.Company
{
    public class CompanyInformation
    {
        public long Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string CompanyName { get; set; } = null!;


        [StringLength(maximumLength: 100)]
        public string? CompanyDescription { get; set; }


        [StringLength(maximumLength: 100)]
        public string? CompanyPhone { get; set; }


        [StringLength(maximumLength: 100)]
        public string? CompanyAddress { get; set; }

        [StringLength(maximumLength: 100)]
        public string? CompanyCity { get; set; }


        [StringLength(maximumLength: 100)]
        public string? CompanyRegion { get; set; }



        [StringLength(maximumLength: 100)]
        public string BusinessCode { get; set; } = null!;


        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }


        //Bire çok ilişki
        #region Relationship
        //public ICollection<SubCompanie>? SubCompanies { get; set; }
        //public ICollection<SubCompany>? SubCompanys { get; set; }
        //public ICollection<Document.Document>? Documents { get; set; }
        #endregion



    }
}
