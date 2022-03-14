using DynamicBox.PurchasingManagement.Core.Repositeries;
using DynamicBox.PurchasingRequestManagement.Core.Models.Product;

namespace DynamicBox.PurchasingRequestManagement.Core.Repositeries
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        Task<List<Product>> GetProductAll();
        Task<List<Product>> GetProductById(long id);
    }
}
