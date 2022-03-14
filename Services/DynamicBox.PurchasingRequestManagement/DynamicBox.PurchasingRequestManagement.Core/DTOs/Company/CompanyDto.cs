using DynamicBox.PurchasingRequestManagement.Core.DTOs;

namespace DynamicBox.PurchasingManagement.Core.DTOs.Company
{
    public class CompanyDto: BaseDto
    {
        public string? CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public string BusinessCode { get; set; }
    }
}
