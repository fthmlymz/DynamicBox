using AutoMapper;
using DynamicBox.PurchasingManagement.Core.Repositeries;
using DynamicBox.PurchasingManagement.Core.UnifOfWorks;
using DynamicBox.PurchasingManagement.Services.Services;
using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Repositeries;
using DynamicBox.PurchasingRequestManagement.Core.Services;

namespace DynamicBox.PurchasingRequestManagement.Services.Services
{
    public class MaterialDemandService : Service<MaterialDemand>, IMaterialDemandService
    {
        private readonly IMaterialDemandRepository _repository;
        private readonly IMapper _mapper;
        public MaterialDemandService(IGenericRepository<MaterialDemand> repository, IUnitOfWork unitOfWork, IMaterialDemandRepository demandRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _repository = demandRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<MaterialDemandWithCompanyDto>>> GetMaterialDemandsWithCompany()
        {
            var material = await _repository.GetMaterialDemandsWithCompany();
            var materialDemandsDto = _mapper.Map<List<MaterialDemandWithCompanyDto>>(material);

            return CustomResponseDto<List<MaterialDemandWithCompanyDto>>.Success(200, materialDemandsDto);
        }

        public async Task<CustomResponseDto<List<MaterialDemandsWithDetailsDto>>> MaterialDemandsWithDetails(long id)
        {
            var material = await _repository.GetMaterialDemandsWithDetails(id);
            var materialDemandsDetailDto = _mapper.Map<List<MaterialDemandsWithDetailsDto>>(material);
            return CustomResponseDto<List<MaterialDemandsWithDetailsDto>>.Success(200, materialDemandsDetailDto);
        }




    }
}
