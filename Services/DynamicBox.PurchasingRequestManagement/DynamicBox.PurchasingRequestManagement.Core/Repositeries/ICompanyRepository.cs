using DynamicBox.PurchasingManagement.Core.Models.Company;
using DynamicBox.PurchasingManagement.Core.Repositeries;

namespace DynamicBox.PurchasingRequestManagement.Core.Repositeries
{
    public interface ICompanyRepository: IGenericRepository<Company>
    {
        Task<Company> GetSingleCompanyByIdWithMaterialsAsync(long companyId);
    }
}
