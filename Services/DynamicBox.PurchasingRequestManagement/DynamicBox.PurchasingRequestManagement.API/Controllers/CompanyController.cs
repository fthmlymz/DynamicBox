using AutoMapper;
using DynamicBox.PurchasingManagement.Core.DTOs.Company;
using DynamicBox.PurchasingManagement.Core.Models.Company;
using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using DynamicBox.PurchasingRequestManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBox.PurchasingRequestManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : CustomBaseController //ControllerBase, 
    {
        private readonly IMapper _mapper;
        private readonly ICompanyService _service;
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(IMapper mapper, ICompanyService service, ILogger<CompanyController> logger)
        {
            _mapper = mapper;
            _service = service;
            _logger = logger;
        }


        //[ServiceFilter(typeof(NotFoundFilter<Company>))]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var company = await _service.GetAllAsync();
            var companyDto = _mapper.Map<List<CompanyDto>>(company.ToList());
            return CreateActionResult(CustomResponseDto<List<CompanyDto>>.Success(200, companyDto));
        }




        [HttpPost]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyDto createCompany)
        {
            var company = await _service.AddAsync(_mapper.Map<Company>(createCompany));
            var companyDto = _mapper.Map<CompanyDto>(company);
            //return Ok(materialDto);
            return CreateActionResult(CustomResponseDto<CompanyDto>.Success(201, companyDto));


            //var material = await _service.AddAsync(_mapper.Map<Company>(createMaterial));
            //var materialDto = _mapper.Map<CompanyDto>(material);
            //return Ok(materialDto);
        }


        //[ServiceFilter(typeof(NotFoundFilter<Company>))]
        [HttpGet("[action]/{companyId}")]
        public async Task<IActionResult> GetSingleCompanyByIdWithMaterialDemands(long companyId)
        {
            //return Ok(companyId);
            return CreateActionResult(await _service.GetSingleCompanyByIdWithMaterialDemandsAsync(companyId));
        }



    }
}
