using DynamicBox.PurchasingManagement.Repository;
using DynamicBox.PurchasingManagement.Repository.Repositories;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Repositeries;
using Microsoft.EntityFrameworkCore;

namespace DynamicBox.PurchasingRequestManagement.Repository.Repositories
{
    public class MaterialDemandRepository: GenericRepository<MaterialDemand>, IMaterialDemandRepository
    {
        public MaterialDemandRepository(DataContext context ): base(context)
        {

        }

        public async Task<List<MaterialDemand>> GetMaterialDemandsWithCompany()
        {
            return await _context.MaterialDemands.Include(x => x.Company).ToListAsync();
        }

        public async Task<List<MaterialDemand>> GetMaterialDemandsWithDetails(long id)
        {

            //return await _context.MaterialDemands.Include(c => c.MaterialDemandDetails).ToListAsync();
            //return await _context.MaterialDemands.Include(c => c.MaterialDemandDetails.Where(x => x.MaterialDemandId == id)).ToListAsync();

            return await _context.MaterialDemands
                                                 .Where(b => b.Id == id)
                                                 .Include(c => c.MaterialDemandDetails)
                                                 .ToListAsync();
        }
    }
}
