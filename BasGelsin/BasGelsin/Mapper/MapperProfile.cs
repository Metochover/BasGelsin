using AutoMapper;
using BasGelsin.Core.DTOs.Address;
using BasGelsin.Core.DTOs.Category;
using BasGelsin.Core.DTOs.Company;
using BasGelsin.Core.DTOs.Menu;
using BasGelsin.Core.DTOs.Product;
using BasGelsin.Core.DTOs.Promotion;
using BasGelsin.Core.DTOs.PromotionProduct;
using BasGelsin.Core.DTOs.User;
using BasGelsin.Data.Concrete;

namespace BasGelsin.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Company, CompanyDTO>();
            CreateMap<Address, AddressDTO>();
            CreateMap<User, UserDTO>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<Category, SubCategoriesDTO>();
            CreateMap<Menu, MenuDTO>();
            CreateMap<Promotion, PromotionDTO>();
            CreateMap<PromotionProduct, PromotionProductDTO>();
        }
    }
}
