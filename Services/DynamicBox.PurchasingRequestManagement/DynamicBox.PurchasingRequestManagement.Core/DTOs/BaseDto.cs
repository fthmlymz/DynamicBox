namespace DynamicBox.PurchasingRequestManagement.Core.DTOs
{
    public  class BaseDto
    {
        public long Id { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int TotalCount { get; set; }
        public long CompanyId { get; set; }
    }
}
