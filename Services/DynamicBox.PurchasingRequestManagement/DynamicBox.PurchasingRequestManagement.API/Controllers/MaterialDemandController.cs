﻿using AutoMapper;
using DynamicBox.PurchasingManagement.Core.Services;
using DynamicBox.PurchasingRequestManagement.API.Controllers;
using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using DynamicBox.PurchasingRequestManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;



namespace DynamicBox.PurchasingManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialDemandController : CustomBaseController //ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IService<MaterialDemand> _service;
        private readonly ILogger<MaterialDemandController> _logger;
        private readonly IMaterialDemandService _materialService;
        public MaterialDemandController(IMapper mapper, IService<MaterialDemand> service, ILogger<MaterialDemandController> logger, IMaterialDemandService materialService)
        {
            _mapper = mapper;
            _service = service;
            _logger = logger;
            _materialService = materialService;
        }


        [HttpGet]
        public async Task<IActionResult> MaterialDemands()
        {
            var material = await _service.GetAllAsync();
            var materialDto = _mapper.Map<List<MaterialDemandDto>>(material.ToList());
            //return Ok(materialDto); //standart
            //return Ok(CustomResponseDto<List<MaterialDemandDto>>.Success(200, materialDto));
            return CreateActionResult(CustomResponseDto<List<MaterialDemandDto>>.Success(200, materialDto));
        }


        //[ServiceFilter(typeof(NotFoundFilter<MaterialDemand>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var material = await _service.GetByIdAsync(id);
            var materialDto = _mapper.Map<MaterialDemandDto>(material);
            //return Ok(materialDto);
            return CreateActionResult(CustomResponseDto<MaterialDemandDto>.Success(200, materialDto));
        }


        [HttpGet("GetMaterialDemandsWithCompany")]
        public async Task<IActionResult> GetMaterialDemandsWithCompany()
        {
            return CreateActionResult(await _materialService.GetMaterialDemandsWithCompany());
        }




        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MaterialDemandDto createMaterial)
        {
            var material = await _service.AddAsync(_mapper.Map<MaterialDemand>(createMaterial));
            var materialDto = _mapper.Map<MaterialDemandDto>(material);
            //return Ok(materialDto);
            return CreateActionResult(CustomResponseDto<MaterialDemandDto>.Success(201, materialDto));
        }



        [HttpPut]
        public async Task<IActionResult> Update([FromBody] MaterialDemandDto updateMaterial)
        {
            await _service.UpdateAsync(_mapper.Map<MaterialDemand>(updateMaterial));
            //return Ok();
            return CreateActionResult(CustomResponseDto<MaterialDemandDto>.Success(204));
        }



        //[ServiceFilter(typeof(NotFoundFilter<MaterialDemand>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(long id)
        {
            var result = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(result);
            //return Ok(id);
            return CreateActionResult(CustomResponseDto<MaterialDemandDto>.Success(200)); //burada nocontent dönmemiz gerekiyor
        }



        [HttpGet("GetMaterialDemandsWithDetails")]
        public async Task<IActionResult> GetMaterialDemandsWithDetails(long id)
        {
            return CreateActionResult(await _materialService.MaterialDemandsWithDetails(id));
        }
    }
}
