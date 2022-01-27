using AutoMapper;
using DynamicBox.DysManagement.Core.DTOs.Company.SubCompany;
using DynamicBox.DysManagement.Core.Models.Company;
using DynamicBox.DysManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBox.DysManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCompanyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<SubCompanie> _service;
        private readonly ILogger<SubCompanie> _logger;

        public SubCompanyController(IMapper mapper, IService<SubCompanie> services, ILogger<SubCompanie> logger)
        {
            _mapper = mapper;
            _service = services;
            _logger = logger;
        }



        [HttpGet]
        public async Task<IActionResult> GetSubCompanys()
        {
            var subCompany = await _service.GetAllAsync();
            var subCompanyDto = _mapper.Map<List<SubCompanieGetDto>>(subCompany.ToList());
            return Ok(subCompanyDto);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdSubCompany(long id)
        {
            var subCompany = await _service.GetByIdAsync(id);
            var subCompanyDto = _mapper.Map<SubCompanieGetDto>(subCompany);
            return Ok(subCompanyDto);
        }


        [HttpPost]
        public async Task<IActionResult> CreateSubCompany([FromBody]SubCompanieCreateDto createSubCompany)
        {
            //var subCompany = await _service.AddAsync(_mapper.Map<SubCompany>(createSubCompany));
            //var subCompanyDto = _mapper.Map<SubCompanyCreateDto>(subCompany);
            //return Ok(subCompanyDto);

            var subCompany = await _service.AddAsync(_mapper.Map<SubCompanie>(createSubCompany));
            var subCompanyDto = _mapper.Map<SubCompanieCreateDto>(subCompany);
            return Ok(subCompanyDto);
        }



        [HttpPut]
        public async Task<IActionResult> Update([FromBody]SubCompanieUpdateDto subCompanyUpdate)
        {
            await _service.UpdateAsync(_mapper.Map<SubCompanie>(subCompanyUpdate));
            return Ok();
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(long id)
        {
            var result = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(result);
            return Ok(id);
        }



    }
}
