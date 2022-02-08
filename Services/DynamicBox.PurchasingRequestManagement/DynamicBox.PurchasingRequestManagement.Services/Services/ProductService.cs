using AutoMapper;
using DynamicBox.PurchasingManagement.Core.Repositeries;
using DynamicBox.PurchasingManagement.Core.UnifOfWorks;
using DynamicBox.PurchasingManagement.Services.Services;
using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Product;
using DynamicBox.PurchasingRequestManagement.Core.Models.Product;
using DynamicBox.PurchasingRequestManagement.Core.Repositeries;
using DynamicBox.PurchasingRequestManagement.Core.Services;

namespace DynamicBox.PurchasingRequestManagement.Services.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _repository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<GetProductDto>>> GetProductAll()
        {
            var product = await _repository.GetProductAll();
            var productsListDto = _mapper.Map<List<GetProductDto>>(product);
            return CustomResponseDto<List<GetProductDto>>.Success(200, productsListDto);
        }

        public async Task<CustomResponseDto<List<GetProductDto>>> GetProductById(int id)
        {
            var product = await _repository.GetProductById(id);
            var productDto = _mapper.Map<List<GetProductDto>>(product);
            return CustomResponseDto<List<GetProductDto>>.Success(200, productDto);
        }
    }
}
