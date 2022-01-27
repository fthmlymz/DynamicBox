using System.ComponentModel.DataAnnotations;

namespace DynamicBox.DysManagement.Core.Models.Company
{
    public class SubCompanie
    {
        public long Id { get; set; }


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
        public DateTime? UpdatedDate { get; set; }



        #region Relationship
        public CompanyInformation CompanyInformation { get; set; } = null!;
        public Document.Document? Documents { get; set; }
        //public ICollection<Document.Document>? Documents { get; set; } 
        #endregion


    }
}
