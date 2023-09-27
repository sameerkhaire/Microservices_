using AutoMapper;

namespace MyShopServices.MappingProfile
{
    public class Productprofile :Profile
    {
        public Productprofile() 
        { 
         CreateMap<Models.Product,DTOS.ProductDto>().ReverseMap();
        }
    }
}
