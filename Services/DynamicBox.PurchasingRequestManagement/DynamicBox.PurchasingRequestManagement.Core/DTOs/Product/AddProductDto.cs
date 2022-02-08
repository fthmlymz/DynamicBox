namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Product
{
    public class AddProductDto:BaseDto
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string StockNo { get; set; }
        public long CompanyId { get; set; }
    }
}
