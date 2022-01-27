using DynamicBox.PurchasingManagement.Core.Models.Company;
using DynamicBox.PurchasingManagement.Repository;
using DynamicBox.PurchasingManagement.Repository.Repositories;
using DynamicBox.PurchasingRequestManagement.Core.Repositeries;
using Microsoft.EntityFrameworkCore;

namespace DynamicBox.PurchasingRequestManagement.Repository.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(DataContext context) : base(context)
        {
        }

        public async Task<Company> GetSingleCompanyByIdWithMaterialsAsync(long companyId)
        {
            return await _context.Companies.Include(x => x.MaterialDemands).Where(x => x.Id == companyId).SingleOrDefaultAsync();
        }
    }
}
