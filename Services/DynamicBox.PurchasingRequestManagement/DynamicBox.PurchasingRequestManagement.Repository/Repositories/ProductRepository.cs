using DynamicBox.PurchasingManagement.Repository;
using DynamicBox.PurchasingManagement.Repository.Repositories;
using DynamicBox.PurchasingRequestManagement.Core.Models.Product;
using DynamicBox.PurchasingRequestManagement.Core.Repositeries;
using Microsoft.EntityFrameworkCore;

namespace DynamicBox.PurchasingRequestManagement.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductAll()
        {
            return await _context.Products.OrderByDescending(x => x.ProductName).ToListAsync();
        }

        public async Task<List<Product>> GetProductById(long id)
        {
            return await _context.Products.Where(x => x.Id == id)
                                          .ToListAsync();
        }
    }
}
