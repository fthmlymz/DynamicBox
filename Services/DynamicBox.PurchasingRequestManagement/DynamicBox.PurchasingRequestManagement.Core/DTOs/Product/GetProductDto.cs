﻿namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Product
{
    public class GetProductDto: BaseDto
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string StockNo { get; set; }
    }
}
