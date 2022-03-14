using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Product;

namespace DynamicBox.PurchasingRequestManagement.Core.Services
{
    public interface IProductService
    {
        Task<CustomResponseDto<List<GetProductDto>>> GetProductAll();
        Task<CustomResponseDto<List<GetProductDto>>> GetProductById(long id);
    }
}


