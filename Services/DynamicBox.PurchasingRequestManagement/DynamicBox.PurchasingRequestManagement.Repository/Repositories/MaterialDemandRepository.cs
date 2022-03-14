using DynamicBox.PurchasingManagement.Repository;
using DynamicBox.PurchasingManagement.Repository.Repositories;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Repositeries;
using Microsoft.EntityFrameworkCore;

namespace DynamicBox.PurchasingRequestManagement.Repository.Repositories
{
    public class MaterialDemandRepository : GenericRepository<MaterialDemand>, IMaterialDemandRepository
    {
        public MaterialDemandRepository(DataContext context) : base(context)
        {

        }

        public async Task<List<MaterialDemandDto>> GetMaterialDemandList(int page, int pageSize)
        {
            IQueryable<MaterialDemand> query;
            query = _context.MaterialDemands
                                        .Include(c => c.MaterialDemandDetails)
                                        .OrderByDescending(x => x.CreatedDate);
            int totalCount = query.Count();
            var response = await query.Skip((pageSize * (page - 1)))
                                       .Take(pageSize)
                                       .Select(x => new MaterialDemandDto()
                                       {
                                           Id = x.Id,
                                           Description = x.Description,
                                           LdapId = x.LdapId,
                                           sAMAAccountName = x.sAMAAccountName,
                                           ObjectGuid = x.ObjectGuid,
                                           Email = x.Email,
                                           PrefferedUserName = x.PrefferedUserName,
                                           Manager = x.Manager,
                                           Status = x.Status,
                                           WorkflowId = x.WorkflowId,
                                           WorkflowDefinitionId = x.WorkflowDefinitionId,
                                           WorkflowName = x.WorkflowName,
                                           WorkflowVersion = x.WorkflowVersion,
                                           CompanyId = x.CompanyId,
                                           CompanyName = x.CompanyName,
                                           CreatedDate = x.CreatedDate,
                                           UpdatedDate = x.UpdatedDate,
                                           TotalCount = totalCount,
                                       })
                                       .ToListAsync();
            return response;
        }



        public async Task<List<MaterialDemand>> GetMaterialDemandsWithCompany()
        {
            return await _context.MaterialDemands.Include(x => x.Company).ToListAsync();
        }

        public async Task<List<MaterialDemand>> GetMaterialDemandsWithDetails(long id)
        {
            return await _context.MaterialDemands
                                                 .Where(b => b.Id == id)
                                                 .Include(c => c.MaterialDemandDetails)
                                                 .OrderByDescending(x => x.CreatedDate)
                                                 .ToListAsync();
        }
    }
}
