using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyShopServices.DTOS;
using MyShopServices.Repository;

namespace MyShopServices.Controllers
{
    [Route("[api/controller]")]
    [ApiController]
  
    public class ProductController : ControllerBase
    {
        private IProductRepo _repo;
        private readonly IMapper _Imapper;
        public ProductController(IProductRepo productRepo,IMapper mapper)
        {
            this._repo = productRepo;
            this._Imapper = mapper;
        }
        [HttpGet]
        public IEnumerable<ProductDto> Get()
        {
            var result= _repo.GetProducts();
            return _Imapper.Map<List<DTOS.ProductDto>>(result);
        }
    }
}
