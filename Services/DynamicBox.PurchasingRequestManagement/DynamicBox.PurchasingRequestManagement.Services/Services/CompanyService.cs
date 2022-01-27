using AutoMapper;
using DynamicBox.PurchasingManagement.Core.Models.Company;
using DynamicBox.PurchasingManagement.Core.Repositeries;
using DynamicBox.PurchasingManagement.Core.UnifOfWorks;
using DynamicBox.PurchasingManagement.Services.Services;
using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Company;
using DynamicBox.PurchasingRequestManagement.Core.Repositeries;
using DynamicBox.PurchasingRequestManagement.Core.Services;

namespace DynamicBox.PurchasingRequestManagement.Services.Services
{
    public class CompanyService : Service<Company>, ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public CompanyService(IGenericRepository<Company> repository, IUnitOfWork unitOfWork, ICompanyRepository companyRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<CompanyWithMaterialDemandsDto>> GetSingleCompanyByIdWithMaterialDemandsAsync(long companyId)
        {
            var company = await _companyRepository.GetSingleCompanyByIdWithMaterialsAsync(companyId);
            var companyDto = _mapper.Map<CompanyWithMaterialDemandsDto>(company);
            return CustomResponseDto<CompanyWithMaterialDemandsDto>.Success(200, companyDto);
        }



    }
}
