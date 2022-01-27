using AutoMapper;
using DynamicBox.PurchasingManagement.Core.Services;
using DynamicBox.PurchasingManagement.Repository;
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBox.PurchasingRequestManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialListController : ControllerBase
    {
        private DataContext _context;
        private IMapper _mapper;
        private IService<MaterialList> _service;

        public MaterialListController(DataContext context, IMapper mapper, IService<MaterialList> service)
        {
            _context = context;
            _mapper = mapper;
            _service = service;
        }









    }
}
