namespace DynamicBox.PurchasingRequestManagement.Core.Models
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
