using AutoMapper;
using DynamicBox.PurchasingManagement.Core.Services;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemandDetail;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBox.PurchasingManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialDemandDetailController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<MaterialDemandDetail> _service;
        private readonly ILogger<MaterialDemandController> _logger;

        public MaterialDemandDetailController(IMapper mapper, IService<MaterialDemandDetail> service, ILogger<MaterialDemandController> logger)
        {
            _mapper = mapper;
            _service = service;
            _logger = logger;
        }




        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var materialList = await _service.GetAllAsync();
            var materialListDto = _mapper.Map<List<MaterialDemandDetail>>(materialList.ToList());
            return Ok(materialListDto);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var materialList = await _service.GetByIdAsync(id);
            var materialListDto = _mapper.Map<MaterialDemandDetailDto>(materialList);
            return Ok(materialListDto);
        }



        [HttpPost]
        public async Task<IActionResult> PostList([FromBody] MaterialDemandDetailDto createMaterialList)
        {
            Console.WriteLine(createMaterialList);

            var material = await _service.AddAsync(_mapper.Map<MaterialDemandDetail>(createMaterialList));
            var materialDto = _mapper.Map<MaterialDemandDetailDto>(material);
            return Ok(materialDto);
        }



        [HttpPut]
        public async Task<IActionResult> Update([FromBody] MaterialDemandDetailDto updateMaterialList)
        {
            await _service.UpdateAsync(_mapper.Map<MaterialDemandDetail>(updateMaterialList));
            return Ok();
        }



        [HttpDelete]
        public async Task<IActionResult> Remove(long id)
        {
            var result = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(result);
            return Ok(id);
        }


    }
}
