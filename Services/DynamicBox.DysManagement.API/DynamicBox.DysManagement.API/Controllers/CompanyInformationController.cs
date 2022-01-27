using AutoMapper;
using DynamicBox.DysManagement.Core.DTOs.Company.CompanyInformation;
using DynamicBox.DysManagement.Core.Models.Company;
using DynamicBox.DysManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBox.DysManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyInformationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<CompanyInformation> _companyService;
        private readonly ILogger<CompanyInformationController> _logger;

        public CompanyInformationController(IMapper mapper, IService<CompanyInformation> companyService, ILogger<CompanyInformationController> logger)
        {
            _mapper = mapper;
            _companyService = companyService;
            _logger = logger;
        }



        [HttpGet]
        public async Task<IActionResult> Company()
        {
            var company = await _companyService.GetAllAsync();
            var companyDto = _mapper.Map<List<CompanyInformationCreateDto>>(company.ToList());
            return Ok(companyDto);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var company = await _companyService.GetByIdAsync(id);
            var companyDto = _mapper.Map<CompanyInformationGetDto>(company);
            return Ok(companyDto);
        }



        [HttpPost]
        public async Task<IActionResult> CreateCompany([FromBody]CompanyInformationCreateDto createCompany)
        {
            var company = await _companyService.AddAsync(_mapper.Map<CompanyInformation>(createCompany));
            var companyDto = _mapper.Map<CompanyInformationCreateDto>(company);
            return Ok(companyDto);
        }
       

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]CompanyInformationUpdateDto updateCompany)
        {
            await _companyService.UpdateAsync(_mapper.Map<CompanyInformation>(updateCompany));
            return Ok();
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(long id)
        {

            var result = await _companyService.GetByIdAsync(id);
            await _companyService.RemoveAsync(result);
            return Ok(id);
        }
    }
}
