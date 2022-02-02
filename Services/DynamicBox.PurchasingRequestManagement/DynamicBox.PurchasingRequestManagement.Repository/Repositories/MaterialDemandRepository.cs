using DynamicBox.PurchasingManagement.Repository;
using DynamicBox.PurchasingManagement.Repository.Repositories;
using DynamicBox.PurchasingRequestManagement.Core.DTOs;
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



        public async Task<(List<MaterialDemand>, int)> GetMaterialDemandList(int page, int pageSize)
        {
            IQueryable<MaterialDemand> query;
            query = _context.MaterialDemands
                                        .Include(c => c.MaterialDemandDetails)
                                        .OrderByDescending(x => x.CreatedDate);
            int totalCount2 = query.Count();
            return (await query.Skip((pageSize * (page - 1))).Take(pageSize).ToListAsync(), totalCount2);
        }

        //public async Task<MaterialDemand> GetMaterialDemandList(int page, int pageSize)
        //{
        //    MaterialDemandDto response = new MaterialDemandDto();
        //    IQueryable<MaterialDemand> query;


        //    query = _context.MaterialDemands
        //                                    .Include(c => c.MaterialDemandDetails)
        //                                    .OrderByDescending(x => x.CreatedDate);
        //    response.TotalCount = query.Count();
        //    response.MaterialDemands = <MaterialDemand>(query.Skip((pageSize * (page - 1))).Take(pageSize).ToListAsync());
        //    return response;
        //}











        ////Sayfalamada async methodu eklenecek. Ek olarak sayfa sayısını cliente göndereceğiz.
        //public async Task<(List<MaterialDemand>,int)> GetMaterialDemandList(int page, int pageSize)
        //{
        //    IQueryable<MaterialDemand> query;

        //    query = _context.MaterialDemands
        //                                    .Include(c => c.MaterialDemandDetails)
        //                                    .OrderByDescending(x => x.CreatedDate);
        //    int totalCount = query.Count();

        //    return await query.Skip((pageSize * (page - 1))).Take(pageSize).ToListAsync();
        //}







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


    public class MyCustomType
    {

        public int TotalAccount { get; set; }
        public List<MaterialDemand> MaterialDemands { get; set; }
    }



}
