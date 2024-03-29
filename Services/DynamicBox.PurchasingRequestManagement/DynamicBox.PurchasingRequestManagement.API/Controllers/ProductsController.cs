﻿using AutoMapper;
using DynamicBox.PurchasingManagement.Core.Services;
using DynamicBox.PurchasingRequestManagement.Core.DTOs;
using DynamicBox.PurchasingRequestManagement.Core.DTOs.Product;
using DynamicBox.PurchasingRequestManagement.Core.Models.Product;
using DynamicBox.PurchasingRequestManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBox.PurchasingRequestManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _service;
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductService _productService;

        public ProductsController(IMapper mapper, IService<Product> service, ILogger<ProductsController> logger, IProductService productService)
        {
            _mapper = mapper;
            _service = service;
            _logger = logger;
            _productService = productService;
        }



        [HttpGet]
        public async Task<IActionResult> GetProductsAll()
        {
            return CreateActionResult(await _productService.GetProductAll());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            //var product = await _productService.GetProductById(id);
            //var productDto = _mapper.Map<List<GetProductDto>>(product);
            //return CreateActionResult(CustomResponseDto<List<GetProductDto>>.Success(200, productDto));
            return CreateActionResult(await _productService.GetProductById(id));
        }


        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] AddProductDto postProduct)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(postProduct));
            var productDto = _mapper.Map<GetProductDto>(product);
            return CreateActionResult(CustomResponseDto<GetProductDto>.Success(200, productDto));
        }


    }
}
